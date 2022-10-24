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
    public partial class MedicineManager : Form
    {
        DataSet ds = new DataSet();
        DataSet Storeds = new DataSet();
        DataTable dtCloned = new DataTable();
        public MedicineManager()
        {
            InitializeComponent();
        }
        private void filldatatodatagridview()
        {
            dtCloned = ds.Tables[0].Clone();
            dtCloned.Columns[3].DataType = typeof(Int32);
            dtCloned.Columns[4].DataType = typeof(Int32);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dtCloned.ImportRow(row);
            }
            dataGridView.DataSource = dtCloned;
            string[] colname = { "Mã thuốc", "Tên Thuốc", "Số lượng", "Đơn giá", "Thành tiền", "Giới thiệu", "Mã cửa hàng" };
            MDIParent.renamecol(dataGridView, colname);
            MDIParent.autofillgirdviewcol(dataGridView, dtCloned.Columns.Count);
            dataGridView.Columns[0].Width = 60;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 60;
            dataGridView.Columns[3].Width = 80;
            dataGridView.Columns[4].Width = 80;
            dataGridView.Columns[5].Width = 150;
            dataGridView.Columns[6].Width = 80;
            txtboxID.DataBindings.Clear();
            txtboxID.DataBindings.Add("Text", dtCloned, "mathuoc");
            txtboxname.DataBindings.Clear();
            txtboxname.DataBindings.Add("Text", dtCloned, "tenthuoc");
            txtboxquantity.DataBindings.Clear();
            txtboxquantity.DataBindings.Add("Text", dtCloned, "soluong");
            txtboxPrice.DataBindings.Clear();
            txtboxPrice.DataBindings.Add("Text", dtCloned, "dongia");
            txtboxTotalcost.DataBindings.Clear();
            txtboxTotalcost.DataBindings.Add("Text", dtCloned, "thanhtien");
            txtboxdesc.DataBindings.Clear();
            txtboxdesc.DataBindings.Add("Text", dtCloned, "gioithieu");
            comboboxStoreID.DataBindings.Clear();
            comboboxStoreID.DataBindings.Add("Text", dtCloned, "macuahang");
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
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Mã thuốc đã tồn tại...", "Chưa " + btntext + " thành công!");
                }
                else
                {
                    MessageBox.Show(ex.ToString(), "Chưa " + btntext + " thành công!");
                }
                return false;
            }
        }
        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicineManager_Load(object sender, EventArgs e)
        {
            LoginForm.dbconn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(@"SELECT * FROM [cuahang];", LoginForm.dbconn);
            sqlData.Fill(Storeds);
            comboboxStoreID.DataSource = Storeds.Tables[0];
            comboboxStoreID.ValueMember = "macuahang";
            refreshBtn_Click(sender, e);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ds.Reset();
            string sql = @"SELECT * FROM [thuoc];";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, LoginForm.dbconn);
            sqlda.Fill(ds);
            filldatatodatagridview();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtboxID.ReadOnly = false;
            txtboxID.DataBindings.Clear();
            txtboxname.DataBindings.Clear();
            txtboxquantity.DataBindings.Clear();
            txtboxPrice.DataBindings.Clear();
            txtboxTotalcost.DataBindings.Clear();
            txtboxdesc.DataBindings.Clear();
            comboboxStoreID.DataBindings.Clear();
            txtboxID.Text = "";
            txtboxname.Text = "";
            txtboxquantity.Text = "";
            txtboxPrice.Text = "";
            txtboxTotalcost.Text = "";
            txtboxdesc.Text = "";
            comboboxStoreID.SelectedIndex = -1;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string Querycmd = @"INSERT INTO [thuoc] ([mathuoc], [tenthuoc], [soluong], [dongia], [gioithieu], [macuahang])
                                VALUES('"+ txtboxID.Text.Trim() + "', N'" + txtboxname.Text.Trim()+"', '" + txtboxquantity.Text.Trim() + "', '" + txtboxPrice.Text.Trim() + "', N'" + txtboxdesc.Text.Trim() + "', '" + comboboxStoreID.SelectedValue.ToString().Trim() + "')";
            if(runQueryCmd(Querycmd, Addbtn.Text))
            {
                refreshBtn_Click(sender, e);
            }
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            string Querycmd = @"UPDATE [thuoc]
                                SET [tenthuoc] = N'" + txtboxname.Text.Trim() + @"',
                                    [soluong] = '" + txtboxquantity.Text.Trim() + @"',
                                    [dongia] = '" + txtboxPrice.Text.Trim() + @"',
                                    [gioithieu] = N'" + txtboxdesc.Text.Trim() + @"',
                                    [macuahang] = '" + comboboxStoreID.SelectedValue.ToString().Trim() + @"'
                                WHERE [mathuoc] = '" + dataGridView.CurrentRow.Cells[0].Value.ToString() + "'";
            if(runQueryCmd(Querycmd, Changebtn.Text))
            {
                refreshBtn_Click(sender, e);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if(runQueryCmd("DELETE FROM [thuoc] WHERE [mathuoc] = '" + dataGridView.CurrentRow.Cells[0].Value.ToString() + "'", Deletebtn.Text))
            { 
                refreshBtn_Click(sender, e);
            }
        }
        private void FirstBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[dtCloned].Position = 0;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[dtCloned].Position++;
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[dtCloned].Position--;
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[dtCloned].Position = dtCloned.Rows.Count - 1;
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            ds.Reset();
            string sql = @"SELECT * FROM [thuoc] ORDER BY [dongia] DESC;";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, LoginForm.dbconn);
            sqlda.Fill(ds);
            filldatatodatagridview();
        }
        private void MedicineManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.dbconn.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search childForm = new Search();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void OnlyNumberType(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
