namespace TT_LT.NET__BTL
{
    partial class FormReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuocDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuocDataSet = new TT_LT.NET__BTL.thuocDataSet();
            this.cuahangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuahangDataSet = new TT_LT.NET__BTL.cuahangDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thuocTableAdapter = new TT_LT.NET__BTL.thuocDataSetTableAdapters.thuocTableAdapter();
            this.cuahangTableAdapter = new TT_LT.NET__BTL.cuahangDataSetTableAdapters.cuahangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataMember = "thuoc";
            this.thuocBindingSource.DataSource = this.thuocDataSetBindingSource;
            // 
            // thuocDataSetBindingSource
            // 
            this.thuocDataSetBindingSource.DataSource = this.thuocDataSet;
            this.thuocDataSetBindingSource.Position = 0;
            // 
            // thuocDataSet
            // 
            this.thuocDataSet.DataSetName = "thuocDataSet";
            this.thuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuahangBindingSource
            // 
            this.cuahangBindingSource.DataMember = "cuahang";
            this.cuahangBindingSource.DataSource = this.cuahangDataSet;
            // 
            // cuahangDataSet
            // 
            this.cuahangDataSet.DataSetName = "cuahangDataSet";
            this.cuahangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "CuahangDS";
            reportDataSource1.Value = this.cuahangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TT_LT.NET__BTL.ReportMedicine.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1260, 572);
            this.reportViewer1.TabIndex = 0;
            // 
            // thuocTableAdapter
            // 
            this.thuocTableAdapter.ClearBeforeFill = true;
            // 
            // cuahangTableAdapter
            // 
            this.cuahangTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 596);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahangDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private thuocDataSet thuocDataSet;
        private System.Windows.Forms.BindingSource thuocDataSetBindingSource;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private thuocDataSetTableAdapters.thuocTableAdapter thuocTableAdapter;
        private cuahangDataSet cuahangDataSet;
        private System.Windows.Forms.BindingSource cuahangBindingSource;
        private cuahangDataSetTableAdapters.cuahangTableAdapter cuahangTableAdapter;
    }
}