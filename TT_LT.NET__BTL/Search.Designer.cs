namespace TT_LT.NET__BTL
{
    partial class Search
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
        private void InitializeComponent()
        {
            this.Quitbtn = new System.Windows.Forms.Button();
            this.conditionbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.keywordtxtbox = new System.Windows.Forms.TextBox();
            this.conditionboxlabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Quitbtn
            // 
            this.Quitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quitbtn.Font = new System.Drawing.Font("Verdana", 9F);
            this.Quitbtn.Location = new System.Drawing.Point(1182, 12);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(90, 42);
            this.Quitbtn.TabIndex = 95;
            this.Quitbtn.Text = "Đóng";
            this.Quitbtn.UseVisualStyleBackColor = true;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // conditionbox
            // 
            this.conditionbox.BackColor = System.Drawing.SystemColors.Window;
            this.conditionbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionbox.Font = new System.Drawing.Font("Verdana", 9F);
            this.conditionbox.FormattingEnabled = true;
            this.conditionbox.Items.AddRange(new object[] {
            "Tên Thuốc",
            "Đơn giá"});
            this.conditionbox.Location = new System.Drawing.Point(584, 82);
            this.conditionbox.Name = "conditionbox";
            this.conditionbox.Size = new System.Drawing.Size(280, 26);
            this.conditionbox.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.Location = new System.Drawing.Point(433, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 102;
            this.label2.Text = "Từ khoá tìm kiếm:";
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Verdana", 9F);
            this.searchbtn.Location = new System.Drawing.Point(468, 170);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(366, 33);
            this.searchbtn.TabIndex = 101;
            this.searchbtn.Text = "Tìm kiếm";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // keywordtxtbox
            // 
            this.keywordtxtbox.Font = new System.Drawing.Font("Verdana", 9F);
            this.keywordtxtbox.Location = new System.Drawing.Point(584, 114);
            this.keywordtxtbox.Name = "keywordtxtbox";
            this.keywordtxtbox.Size = new System.Drawing.Size(280, 26);
            this.keywordtxtbox.TabIndex = 100;
            this.keywordtxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keywordtxtbox_KeyDown);
            this.keywordtxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keywordtxtbox_KeyPress);
            // 
            // conditionboxlabel
            // 
            this.conditionboxlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionboxlabel.AutoSize = true;
            this.conditionboxlabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.conditionboxlabel.Location = new System.Drawing.Point(433, 85);
            this.conditionboxlabel.Name = "conditionboxlabel";
            this.conditionboxlabel.Size = new System.Drawing.Size(122, 18);
            this.conditionboxlabel.TabIndex = 99;
            this.conditionboxlabel.Text = "Tìm kiếm theo:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(126, 227);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1033, 336);
            this.dataGridView.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(540, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Tìm kiếm thông tin thuốc";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 596);
            this.Controls.Add(this.conditionbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.keywordtxtbox);
            this.Controls.Add(this.conditionboxlabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quitbtn);
            this.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Quitbtn;
        private System.Windows.Forms.ComboBox conditionbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox keywordtxtbox;
        private System.Windows.Forms.Label conditionboxlabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
    }
}