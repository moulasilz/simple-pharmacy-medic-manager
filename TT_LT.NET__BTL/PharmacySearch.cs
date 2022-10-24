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

namespace TT_LT.NET__BTL
{
    public partial class PharmacySearch : Form
    {
        DataSet ds = new DataSet();

        public PharmacySearch()
        {
            InitializeComponent();
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
        private void filldatatodatagridview(string sql)
        {
            ds.Reset();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, LoginForm.dbconn);
            sqlda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            string[] colname = { "Mã cửa hàng", "Tên cửa hàng", "Địa chỉ", "Điện thoại", "Email" };
            MDIParent.renamecol(dataGridView, colname);
            MDIParent.autofillgirdviewcol(dataGridView, ds.Tables[0].Columns.Count);
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string sqlstring = "Select * from [cuahang] where [tencuahang] LIKE N'%"+ keywordtxtbox.Text.Trim() +"%'";
            filldatatodatagridview(sqlstring);
        }

        private void keywordtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchbtn_Click(sender, e);
            }
        }
    }
}
