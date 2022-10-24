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
    public partial class Search : Form
    {
        DataSet ds = new DataSet();
        public Search()
        {
            InitializeComponent();
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keywordtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(conditionbox.SelectedIndex == 1)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            conditionbox.SelectedIndex = 0;
        }
        private void filldatatodatagridview(string sql)
        {
            ds.Reset();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, LoginForm.dbconn);
            sqlda.Fill(ds);
            DataTable dtCloned = ds.Tables[0].Clone();
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
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (conditionbox.SelectedIndex == 0)
            {
                string sqlstring = "Select * from [thuoc] where [tenthuoc] LIKE N'%"+ keywordtxtbox.Text.Trim() +"%'";
                filldatatodatagridview(sqlstring);
            }
            else
            {
                string sqlstring = "Select * from [thuoc] where [dongia] = '" + keywordtxtbox.Text.Trim() + "'";
                filldatatodatagridview(sqlstring);
            }
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
