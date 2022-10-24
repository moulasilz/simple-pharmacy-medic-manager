using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
                                        //02_02_HTLongNVDucPDHoang_LTNET
namespace TT_LT.NET__BTL
{
    public partial class LoginForm : Form
    {
        public static SqlConnection dbconn = new SqlConnection(Program.stringconnect);
        public static bool isAdmin = false;
        public static DataTable userInfo = new DataTable();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void formclose()
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Thoát...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            formclose();
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            formclose();
        }
        private void txtboxusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }

        private void txtboxpasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtboxusername.Text.Trim() == "" || txtboxpasswd.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu đăng nhập!");
                if (txtboxusername.Text.Trim() == "") txtboxusername.Focus();
                else txtboxpasswd.Focus();
            }
            else
            {
                string stringcmd = "Select * from dbo.dangnhap where username = '" + txtboxusername.Text.Trim() + "' AND password = '" + txtboxpasswd.Text.Trim() + "' ";
                SqlCommand ConnectCommand = new SqlCommand(stringcmd, dbconn);
                dbconn.Open();
                var table = new DataTable();
                var datareader = ConnectCommand.ExecuteReader();
                table.Load(datareader);
                if (table.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(table.Rows[0][5]))
                    {
                        isAdmin = Convert.ToBoolean(table.Rows[0][4]);
                        MessageBox.Show("Bạn đã đăng nhập thành công!");
                        userInfo = table;
                        MDIParent form = new MDIParent();
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đang bị khoá, vui lòng liên hệ Admin!");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Đăng nhập thất bại...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxpasswd.Focus();
                }
                dbconn.Close();
            }
        }

        private void showhidepasswd_CheckedChanged(object sender, EventArgs e)
        {
            if(showhidepasswd.Checked == true)
            {
                txtboxpasswd.PasswordChar = '\0';

            }
            else
            {
                txtboxpasswd.PasswordChar = '*';
            }
        }
    }
}
