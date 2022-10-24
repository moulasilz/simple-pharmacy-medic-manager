namespace TT_LT.NET__BTL
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userlabel = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtboxpasswd = new System.Windows.Forms.TextBox();
            this.passwdlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitlabel = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.showhidepasswd = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userlabel
            // 
            this.userlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.userlabel.Location = new System.Drawing.Point(142, 161);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(134, 18);
            this.userlabel.TabIndex = 0;
            this.userlabel.Text = "Tên đăng nhập:";
            // 
            // txtboxusername
            // 
            this.txtboxusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxusername.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtboxusername.Location = new System.Drawing.Point(279, 158);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(266, 26);
            this.txtboxusername.TabIndex = 1;
            this.txtboxusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxusername_KeyPress);
            // 
            // txtboxpasswd
            // 
            this.txtboxpasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxpasswd.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtboxpasswd.Location = new System.Drawing.Point(279, 200);
            this.txtboxpasswd.Name = "txtboxpasswd";
            this.txtboxpasswd.PasswordChar = '*';
            this.txtboxpasswd.Size = new System.Drawing.Size(266, 26);
            this.txtboxpasswd.TabIndex = 3;
            this.txtboxpasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxpasswd_KeyPress);
            // 
            // passwdlabel
            // 
            this.passwdlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwdlabel.AutoSize = true;
            this.passwdlabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.passwdlabel.Location = new System.Drawing.Point(142, 203);
            this.passwdlabel.Name = "passwdlabel";
            this.passwdlabel.Size = new System.Drawing.Size(90, 18);
            this.passwdlabel.TabIndex = 2;
            this.passwdlabel.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(274, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đăng nhập tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.exitlabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 90);
            this.panel1.TabIndex = 5;
            // 
            // exitlabel
            // 
            this.exitlabel.AutoSize = true;
            this.exitlabel.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitlabel.Location = new System.Drawing.Point(678, 0);
            this.exitlabel.Name = "exitlabel";
            this.exitlabel.Size = new System.Drawing.Size(39, 40);
            this.exitlabel.TabIndex = 8;
            this.exitlabel.Text = "x";
            this.exitlabel.Click += new System.EventHandler(this.exitlabel_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(205, 265);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(127, 31);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(371, 265);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(127, 31);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // showhidepasswd
            // 
            this.showhidepasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showhidepasswd.AutoSize = true;
            this.showhidepasswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showhidepasswd.Location = new System.Drawing.Point(465, 230);
            this.showhidepasswd.Name = "showhidepasswd";
            this.showhidepasswd.Size = new System.Drawing.Size(80, 20);
            this.showhidepasswd.TabIndex = 8;
            this.showhidepasswd.Text = "Ẩn/Hiện";
            this.showhidepasswd.UseVisualStyleBackColor = true;
            this.showhidepasswd.CheckedChanged += new System.EventHandler(this.showhidepasswd_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.showhidepasswd);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxpasswd);
            this.Controls.Add(this.passwdlabel);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.userlabel);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 400);
            this.MinimumSize = new System.Drawing.Size(720, 400);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.TextBox txtboxpasswd;
        private System.Windows.Forms.Label passwdlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label exitlabel;
        private System.Windows.Forms.CheckBox showhidepasswd;
    }
}

