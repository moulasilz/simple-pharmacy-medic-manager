using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
                                    //02_02_HTLongNVDucPDHoang_LTNET
namespace TT_LT.NET__BTL
{
    public partial class FormReportView : Form
    {
        public FormReportView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            if (MDIParent.IsMedicineReport)
            {
                // TODO: This line of code loads data into the 'thuocDataSet.thuoc' table. You can move, or remove it, as needed.
                reportViewer1.Reset();
                reportDataSource1.Name = "thuocDS";
                reportDataSource1.Value = this.thuocBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "TT_LT.NET__BTL.ReportMedicine.rdlc";
                this.thuocTableAdapter.Fill(this.thuocDataSet.thuoc);
            }
            else
            {
                // TODO: This line of code loads data into the 'cuahangDataSet.cuahang' table. You can move, or remove it, as needed.
                reportViewer1.Reset();
                reportDataSource1.Name = "CuahangDS";
                reportDataSource1.Value = this.cuahangBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "TT_LT.NET__BTL.ReportPharmacy.rdlc";
                this.cuahangTableAdapter.Fill(this.cuahangDataSet.cuahang);
            }
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
