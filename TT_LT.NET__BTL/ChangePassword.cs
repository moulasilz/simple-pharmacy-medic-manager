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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Showpasswd(CheckBox checkbox, TextBox txtboxpasswd)
        {
            if (checkbox.Checked == true)
            {
                txtboxpasswd.PasswordChar = '\0';

            }
            else
            {
                txtboxpasswd.PasswordChar = '*';
            }
        }
        private void showpasswd_CheckedChanged(object sender, EventArgs e)
        {
            Showpasswd(showpasswd, txtboxPasswd);
        }

        private void shownewpasswd_CheckedChanged(object sender, EventArgs e)
        {
            Showpasswd(shownewpasswd, txtboxnewpasswd);
        }

        private void showcofirm_CheckedChanged(object sender, EventArgs e)
        {
            Showpasswd(showcofirm, txtboxconfirm);
        }


        private bool[] isValid = { false , false , false };
        private void errorMessage(TextBox txt, Label message, int validvalue)
        {
            if (txt.Text.Trim() != "")
            {
                message.Visible = false;
                isValid[validvalue] = true;
            }
            else
            {
                message.Visible = true;
                isValid[validvalue] = false;
            }
        }
        private void IsComfirmed()
        {
            if (txtboxconfirm.Text.Trim() != txtboxnewpasswd.Text.Trim())
            {
                errorconfirm.Visible = true;
                isValid[2] = false;
            }
            else
            {
                errorconfirm.Visible = false;
                isValid[2] = true;
            }
        }
        private void txtboxPasswd_TextChanged(object sender, EventArgs e)
        {
            errorMessage(txtboxPasswd, errorPasswd, 0);

        }
        private void txtboxnewpasswd_TextChanged(object sender, EventArgs e)
        {
            errorMessage(txtboxnewpasswd, errornewpasswd, 1);
            IsComfirmed();
        }
        private void txtboxconfirm_TextChanged(object sender, EventArgs e)
        {
            IsComfirmed();
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            txtboxPasswd_TextChanged(sender, null);
            txtboxnewpasswd_TextChanged(sender, null);
            txtboxconfirm_TextChanged(sender, null);
            foreach (bool check in isValid)
            {
                if (!check)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
            }
            
            string username = LoginForm.userInfo.Rows[0][0].ToString();
            using(var sqlCommand = new SqlCommand())
            {
                LoginForm.dbconn.Open();
                sqlCommand.Connection = LoginForm.dbconn;
                sqlCommand.CommandText = @"Select * from dbo.dangnhap where username = '" + username + "' AND password = '" + txtboxPasswd.Text.Trim() + "' ";
                var table = new DataTable();
                var datareader = sqlCommand.ExecuteReader();
                table.Load(datareader);
                if (table.Rows.Count > 0)
                {
                    string sqlstring = @"UPDATE [dangnhap] SET [password] = '" + txtboxconfirm.Text.Trim() + "' WHERE [username] = '" + username + "'";
                    sqlCommand.CommandText = sqlstring;
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Đã thay đổi mật khẩu thành công!\n\nnhấn OK để trở về trang chủ.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Chưa thay đổi mật khẩu thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                    txtboxPasswd.Focus();
                }
                LoginForm.dbconn.Close();
            }
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
