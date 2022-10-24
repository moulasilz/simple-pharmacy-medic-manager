using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
                                    //02_02_HTLongNVDucPDHoang_LTNET
namespace TT_LT.NET__BTL
{
    public partial class PharmacyManager : Form
    {
        DataSet ds = new DataSet();
        public PharmacyManager()
        {
            InitializeComponent();
        }

        private void filldatatodatagridview()
        {
            dataGridView.DataSource = ds.Tables[0];
            string[] colname = { "Mã cửa hàng", "Tên cửa hàng", "Địa chỉ", "Điện thoại", "Email" };
            MDIParent.renamecol(dataGridView, colname);
            MDIParent.autofillgirdviewcol(dataGridView, ds.Tables[0].Columns.Count);
            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[3].Width = 100;
            txtboxname.DataBindings.Clear();
            txtboxname.DataBindings.Add("Text", ds.Tables[0], "tencuahang");
            txtboxID.DataBindings.Clear();
            txtboxID.DataBindings.Add("Text", ds.Tables[0], "macuahang");
            txtboxaddress.DataBindings.Clear();
            txtboxaddress.DataBindings.Add("Text", ds.Tables[0], "diachi");
            txtboxemail.DataBindings.Clear();
            txtboxemail.DataBindings.Add("Text", ds.Tables[0], "email");
            txtboxphone.DataBindings.Clear();
            txtboxphone.DataBindings.Add("Text", ds.Tables[0], "dienthoai");
            txtboxID.ReadOnly = true;
        }
        private bool runQueryCmd(string Querycmd, string btntext)
        {
            try
            {
                SqlCommand sqlcommand = new SqlCommand(Querycmd, LoginForm.dbconn);
                int result = sqlcommand.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Đã " + btntext + " thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Chưa " + btntext + " thành công!");
                    return false;
                }
            }
            catch (SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    MessageBox.Show("Mã cửa hàng đã tồn tại...", "Chưa " + btntext + " thành công!");
                }
                if(ex.Number == 547)
                {
                    MessageBox.Show("Tồn tại thông tin thuốc thuộc mã cửa hàng, vui lòng xoá hoặc sửa chúng trước khi xoá cửa hàng này...", "Chưa " + btntext + " thành công!");
                }
                return false;
            }
        }
        private void txtboxphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void PharmacyManager_Load(object sender, EventArgs e)
        {
            LoginForm.dbconn.Open();
            refreshBtn_Click(sender, e);
        }
        private void PharmacyManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.dbconn.Close();
        }
        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string Querycmd = @"insert into cuahang([macuahang], [tencuahang], [diachi], [dienthoai], [email])
                                values('" + txtboxID.Text.Trim() + "', N'" + txtboxname.Text.Trim() + "', N'" + txtboxaddress.Text.Trim() + "', '" + txtboxphone.Text.Trim() + "', '" + txtboxemail.Text.Trim() + "')";
            if(runQueryCmd(Querycmd, Addbtn.Text))
            {
                refreshBtn_Click(sender, e);
            }
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            string Querycmd = @"UPDATE [cuahang]
                                SET [tencuahang] = N'" + txtboxname.Text.Trim() + @"',
                                    [diachi] = N'" + txtboxaddress.Text.Trim() + @"',
                                    [dienthoai] = '" + txtboxphone.Text.Trim() + @"',
                                    [email] = '" + txtboxemail.Text.Trim() + @"'
                                WHERE [macuahang] = '" + txtboxID.Text.Trim() + "'";
            if(runQueryCmd(Querycmd, Changebtn.Text))
            {
                refreshBtn_Click(sender, e);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if(runQueryCmd("DELETE FROM [cuahang] WHERE [macuahang] = '" + txtboxID.Text.Trim() + "'", Deletebtn.Text))
            {
                refreshBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ds.Reset();
            string sql = @"SELECT * FROM [cuahang];";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, LoginForm.dbconn);
            sqlda.Fill(ds);
            filldatatodatagridview();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtboxID.ReadOnly = false;
            txtboxID.DataBindings.Clear();
            txtboxname.DataBindings.Clear();
            txtboxaddress.DataBindings.Clear();
            txtboxphone.DataBindings.Clear();
            txtboxemail.DataBindings.Clear();
            txtboxID.Text = "";
            txtboxname.Text = "";
            txtboxaddress.Text = "";
            txtboxphone.Text = "";
            txtboxphone.Text = "";
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = 0;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position++;
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position--;
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = ds.Tables[0].Rows.Count - 1;
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            ds.Reset();
            string sql = @"SELECT * FROM [cuahang] ORDER BY [tencuahang] DESC;";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, LoginForm.dbconn);
            sqlda.Fill(ds);
            filldatatodatagridview();
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PharmacySearch childForm = new PharmacySearch();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
