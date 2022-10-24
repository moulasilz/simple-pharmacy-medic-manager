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
    public partial class AccountManager : Form
    {
        DataSet ds = new DataSet();
        
        public AccountManager()
        {
            InitializeComponent();
        }
        private void filldatatodatagridview()
        {
            ds.Reset();
            string sql = @"SELECT * FROM [dangnhap];";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, LoginForm.dbconn);
            sqlda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            string[] colname = {"Tên đăng nhâp", "Mật khẩu", "Tên đầy đủ", "Email", "Người dùng", "Trạng thái"};
            MDIParent.autofillgirdviewcol(dataGridView, ds.Tables[0].Columns.Count);
            dataGridView.Columns[4].Width = 50;
            dataGridView.Columns[5].Width = 50;
            MDIParent.renamecol(dataGridView, colname);
            txtboxUsername.DataBindings.Clear();
            txtboxUsername.DataBindings.Add("Text", ds.Tables[0], "username");
            txtboxFullname.DataBindings.Clear();
            txtboxFullname.DataBindings.Add("Text", ds.Tables[0], "fullname");
            txtboxPasswd.DataBindings.Clear();
            txtboxPasswd.DataBindings.Add("Text", ds.Tables[0], "password");
            txtboxEmail.DataBindings.Clear();
            txtboxEmail.DataBindings.Add("Text", ds.Tables[0], "email");
            txtboxUsername.ReadOnly = true;
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
                    MessageBox.Show("Tên đăng nhập đã tồn tại...", "Chưa " + btntext + " thành công!");
                }
                else
                {
                    MessageBox.Show(ex.ToString(), "Chưa " + btntext + " thành công!");
                }
                return false;
            }
        }
        private bool ModCheck()
        {
            if (radiobtnAdmin.Checked == true)
            {
                return false;
            }
            return true;
        }
        private bool Statecheck()
        {
            if (radiobtnIslocked.Checked == true)
            {
                return false;
            }
            return true;
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {

            LoginForm.dbconn.Open();
            filldatatodatagridview();
        }

        private void AccountManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.dbconn.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ModCheck();
            Statecheck();
            string Querycmd = @"insert into dangnhap([username], [password], [fullname], [email], [mod], [state])
                                values('"+ txtboxUsername.Text.Trim() +"', '"+ txtboxPasswd.Text.Trim() + "', N'"+txtboxFullname.Text.Trim()+"', '"+ txtboxEmail.Text.Trim() +"', '"+ Convert.ToInt32(ModCheck()).ToString() + "', '" + Convert.ToInt32(Statecheck()).ToString() + "')";
            if(runQueryCmd(Querycmd, Addbtn.Text))
            {
                refreshBtn_Click(sender, e);
            }
            
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            ModCheck();
            Statecheck();
            string Querycmd = @"UPDATE [dangnhap]
                                SET [password] = '" + txtboxPasswd.Text.Trim() + @"',
                                    [fullname] = N'" + txtboxFullname.Text.Trim() + @"',
                                    [email] = '" + txtboxEmail.Text.Trim() + @"',
                                    [mod] = '"+ Convert.ToInt32(ModCheck()).ToString() + @"',
                                    [state] = '"+ Convert.ToInt32(Statecheck()).ToString() + @"'
                                WHERE [username] = '"+ txtboxUsername.Text.Trim() + "'";
            if (runQueryCmd(Querycmd, Changebtn.Text)) 
            { 
                refreshBtn_Click(sender, e); 
            } 
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if(runQueryCmd("DELETE FROM [dangnhap] WHERE [username] = '" + txtboxUsername.Text.Trim() + "'", Deletebtn.Text))
            {
                refreshBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            filldatatodatagridview();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells[4].Value.ToString() == "False")
            {
                radiobtnAdmin.Checked = true;
            }
            else
            {
                radiobtnUser.Checked = true;
            }
            if (dataGridView.CurrentRow.Cells[5].Value.ToString() == "False")
            {
                radiobtnIslocked.Checked = true;
            }
            else
            {
                radiobtnIsopenned.Checked = true;
            }
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = 0;
            dataGridView_CellClick(sender, null);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position++;
            dataGridView_CellClick(sender, null);
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position--;
            dataGridView_CellClick(sender, null);
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = ds.Tables[0].Rows.Count - 1;
            dataGridView_CellClick(sender, null);
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtboxUsername.ReadOnly = false;
            txtboxUsername.DataBindings.Clear();
            txtboxFullname.DataBindings.Clear();
            txtboxPasswd.DataBindings.Clear();
            txtboxEmail.DataBindings.Clear();
            txtboxUsername.Text = "";
            txtboxPasswd.Text = "";
            txtboxFullname.Text = "";
            txtboxEmail.Text = "";
            radiobtnUser.Checked = true;
            radiobtnIsopenned.Checked = true;
        }
    }
}
