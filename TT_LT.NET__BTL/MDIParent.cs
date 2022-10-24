using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
                                    //02_02_HTLongNVDucPDHoang_LTNET
namespace TT_LT.NET__BTL
{
    public partial class MDIParent : Form
    {
        public static void autofillgirdviewcol(DataGridView dataGridView, int count)
        {
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
        public static void renamecol(DataGridView dataGridView, string[] nameofcol)
        {
            if (dataGridView.Columns.Count != 0)
            {
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataGridView.Columns[i].HeaderText = nameofcol[i];
                }
            }

        }
        public MDIParent()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Add(childForm);
            panelMainContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.MdiParent = this;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }*/
        }




        private void MDIParent_Load(object sender, EventArgs e)
        {
            username.Text = LoginForm.userInfo.Rows[0]["username"].ToString();
            fullname.Text = LoginForm.userInfo.Rows[0]["fullname"].ToString();
            email.Text = LoginForm.userInfo.Rows[0]["email"].ToString();

            if (LoginForm.isAdmin)
            {
                UsermanageMenuItem.Visible = false;
                UsermanageMenuItem.Enabled = false;
                role.Text = "Người dùng(User)";
            }
            else
            {
                MessageBox.Show("Bạn đã đăng nhập tài khoản admin!");
                role.Text = "Quản trị viên(Administrator)";
            }
        }
        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Thoát...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void MDIParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //trở về trang chủ 
        private void homeMenuItem_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }
        // Menu hệ thống
        private void UsermanageMenuItem_Click(object sender, EventArgs e)
        {
            AccountManager childForm = new AccountManager();
            openChildFormInPanel(childForm);
        }

        private void ChangePasswdMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword childForm = new ChangePassword();
            openChildFormInPanel(childForm);
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Menu quản lý
        private void StoreManageMenuItem_Click(object sender, EventArgs e)
        {
            PharmacyManager childForm = new PharmacyManager();
            openChildFormInPanel(childForm);
        }

        private void MedicineManageMenuItem_Click(object sender, EventArgs e)
        {
            MedicineManager childForm = new MedicineManager();
            openChildFormInPanel(childForm);
        }
        //Menu báo cáo

        public static bool IsMedicineReport;
        private void medicineReportMenuItem_Click(object sender, EventArgs e)
        {
            IsMedicineReport = true;
            FormReportView childForm = new FormReportView();
            openChildFormInPanel(childForm);
        }

        private void StoreReportMenuItem_Click(object sender, EventArgs e)
        {
            IsMedicineReport = false;
            FormReportView childForm = new FormReportView();
            openChildFormInPanel(childForm);
        }

        // Menu tiện ích
        private void wordMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"WINWORD.EXE");
        }

        private void exelMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }

        private void paintMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        // Menu trợ giúp
        private void AuthorMenuItem_Click(object sender, EventArgs e)
        {
            Author childForm = new Author();
            openChildFormInPanel(childForm);
        }

        private void CopyrightMenuItem_Click(object sender, EventArgs e)
        {
            Copyrights childForm = new Copyrights();
            openChildFormInPanel(childForm);
        }

        private void TutorialMenuItem_Click(object sender, EventArgs e)
        {
            Tutorial childForm = new Tutorial();
            openChildFormInPanel(childForm);
        }
    }
}
