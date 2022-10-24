namespace TT_LT.NET__BTL
{
    partial class ChangePassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxnewpasswd = new System.Windows.Forms.TextBox();
            this.txtboxconfirm = new System.Windows.Forms.TextBox();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxPasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showpasswd = new System.Windows.Forms.CheckBox();
            this.shownewpasswd = new System.Windows.Forms.CheckBox();
            this.showcofirm = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorPasswd = new System.Windows.Forms.Label();
            this.errornewpasswd = new System.Windows.Forms.Label();
            this.errorconfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F);
            this.label4.Location = new System.Drawing.Point(405, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 97;
            this.label4.Text = "Mật khẩu hiện tại";
            // 
            // txtboxnewpasswd
            // 
            this.txtboxnewpasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxnewpasswd.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtboxnewpasswd.Location = new System.Drawing.Point(586, 198);
            this.txtboxnewpasswd.Name = "txtboxnewpasswd";
            this.txtboxnewpasswd.PasswordChar = '*';
            this.txtboxnewpasswd.Size = new System.Drawing.Size(262, 26);
            this.txtboxnewpasswd.TabIndex = 78;
            this.txtboxnewpasswd.TextChanged += new System.EventHandler(this.txtboxnewpasswd_TextChanged);
            // 
            // txtboxconfirm
            // 
            this.txtboxconfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxconfirm.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtboxconfirm.Location = new System.Drawing.Point(586, 249);
            this.txtboxconfirm.Name = "txtboxconfirm";
            this.txtboxconfirm.PasswordChar = '*';
            this.txtboxconfirm.Size = new System.Drawing.Size(262, 26);
            this.txtboxconfirm.TabIndex = 80;
            this.txtboxconfirm.TextChanged += new System.EventHandler(this.txtboxconfirm_TextChanged);
            // 
            // Quitbtn
            // 
            this.Quitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quitbtn.Location = new System.Drawing.Point(1182, 12);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(90, 42);
            this.Quitbtn.TabIndex = 87;
            this.Quitbtn.Text = "Đóng";
            this.Quitbtn.UseVisualStyleBackColor = true;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshBtn.Font = new System.Drawing.Font("Verdana", 9F);
            this.refreshBtn.Location = new System.Drawing.Point(408, 321);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(487, 38);
            this.refreshBtn.TabIndex = 88;
            this.refreshBtn.Text = "Đổi mật khẩu";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            this.label6.Location = new System.Drawing.Point(506, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 25);
            this.label6.TabIndex = 93;
            this.label6.Text = "Quản lý thông tin tài khoản";
            // 
            // txtboxPasswd
            // 
            this.txtboxPasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPasswd.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtboxPasswd.Location = new System.Drawing.Point(586, 145);
            this.txtboxPasswd.Name = "txtboxPasswd";
            this.txtboxPasswd.PasswordChar = '*';
            this.txtboxPasswd.Size = new System.Drawing.Size(262, 26);
            this.txtboxPasswd.TabIndex = 98;
            this.txtboxPasswd.TextChanged += new System.EventHandler(this.txtboxPasswd_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(405, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.Location = new System.Drawing.Point(405, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 100;
            this.label2.Text = "Nhập lại mật khẩu mới";
            // 
            // showpasswd
            // 
            this.showpasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showpasswd.AutoSize = true;
            this.showpasswd.Location = new System.Drawing.Point(877, 151);
            this.showpasswd.Name = "showpasswd";
            this.showpasswd.Size = new System.Drawing.Size(18, 17);
            this.showpasswd.TabIndex = 101;
            this.showpasswd.UseVisualStyleBackColor = true;
            this.showpasswd.CheckedChanged += new System.EventHandler(this.showpasswd_CheckedChanged);
            // 
            // shownewpasswd
            // 
            this.shownewpasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shownewpasswd.AutoSize = true;
            this.shownewpasswd.Location = new System.Drawing.Point(877, 204);
            this.shownewpasswd.Name = "shownewpasswd";
            this.shownewpasswd.Size = new System.Drawing.Size(18, 17);
            this.shownewpasswd.TabIndex = 102;
            this.shownewpasswd.UseVisualStyleBackColor = true;
            this.shownewpasswd.CheckedChanged += new System.EventHandler(this.shownewpasswd_CheckedChanged);
            // 
            // showcofirm
            // 
            this.showcofirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showcofirm.AutoSize = true;
            this.showcofirm.Location = new System.Drawing.Point(877, 255);
            this.showcofirm.Name = "showcofirm";
            this.showcofirm.Size = new System.Drawing.Size(18, 17);
            this.showcofirm.TabIndex = 103;
            this.showcofirm.UseVisualStyleBackColor = true;
            this.showcofirm.CheckedChanged += new System.EventHandler(this.showcofirm_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F);
            this.label3.Location = new System.Drawing.Point(853, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 104;
            this.label3.Text = "Ẩn/Hiện";
            // 
            // errorPasswd
            // 
            this.errorPasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorPasswd.AutoSize = true;
            this.errorPasswd.Font = new System.Drawing.Font("Verdana", 7F);
            this.errorPasswd.ForeColor = System.Drawing.Color.Red;
            this.errorPasswd.Location = new System.Drawing.Point(595, 174);
            this.errorPasswd.Name = "errorPasswd";
            this.errorPasswd.Size = new System.Drawing.Size(164, 14);
            this.errorPasswd.TabIndex = 105;
            this.errorPasswd.Text = "Bạn chưa nhập mật khẩu";
            this.errorPasswd.Visible = false;
            // 
            // errornewpasswd
            // 
            this.errornewpasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errornewpasswd.AutoSize = true;
            this.errornewpasswd.Font = new System.Drawing.Font("Verdana", 7F);
            this.errornewpasswd.ForeColor = System.Drawing.Color.Red;
            this.errornewpasswd.Location = new System.Drawing.Point(595, 227);
            this.errornewpasswd.Name = "errornewpasswd";
            this.errornewpasswd.Size = new System.Drawing.Size(190, 14);
            this.errornewpasswd.TabIndex = 106;
            this.errornewpasswd.Text = "Bạn chưa nhập mật khẩu mới";
            this.errornewpasswd.Visible = false;
            // 
            // errorconfirm
            // 
            this.errorconfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorconfirm.AutoSize = true;
            this.errorconfirm.Font = new System.Drawing.Font("Verdana", 7F);
            this.errorconfirm.ForeColor = System.Drawing.Color.Red;
            this.errorconfirm.Location = new System.Drawing.Point(595, 279);
            this.errorconfirm.Name = "errorconfirm";
            this.errorconfirm.Size = new System.Drawing.Size(207, 14);
            this.errorconfirm.TabIndex = 107;
            this.errorconfirm.Text = "Mật khẩu mới không trùng khớp";
            this.errorconfirm.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 596);
            this.Controls.Add(this.errorconfirm);
            this.Controls.Add(this.errornewpasswd);
            this.Controls.Add(this.errorPasswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showcofirm);
            this.Controls.Add(this.shownewpasswd);
            this.Controls.Add(this.showpasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxPasswd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.txtboxconfirm);
            this.Controls.Add(this.txtboxnewpasswd);
            this.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxnewpasswd;
        private System.Windows.Forms.TextBox txtboxconfirm;
        private System.Windows.Forms.Button Quitbtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxPasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showpasswd;
        private System.Windows.Forms.CheckBox shownewpasswd;
        private System.Windows.Forms.CheckBox showcofirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorPasswd;
        private System.Windows.Forms.Label errornewpasswd;
        private System.Windows.Forms.Label errorconfirm;
    }
}