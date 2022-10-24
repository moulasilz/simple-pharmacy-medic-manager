namespace TT_LT.NET__BTL
{
    partial class MDIParent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsermanageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MedicineManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.StoreManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StoreReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtentionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.paintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TutorialMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyrightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.cuahangTableAdapter1 = new TT_LT.NET__BTL.cuahangDataSetTableAdapters.cuahangTableAdapter();
            this.menuStrip.SuspendLayout();
            this.panelMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuItem,
            this.systemMenu,
            this.ManagerMenu,
            this.ReportMenu,
            this.ExtentionMenu,
            this.HelpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1302, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.home_circle_icon;
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.Size = new System.Drawing.Size(34, 26);
            this.homeMenuItem.Click += new System.EventHandler(this.homeMenuItem_Click);
            // 
            // systemMenu
            // 
            this.systemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsermanageMenuItem,
            this.ChangePasswdMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.systemMenu.Image = global::TT_LT.NET__BTL.Properties.Resources.preferences_system;
            this.systemMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.systemMenu.Name = "systemMenu";
            this.systemMenu.Size = new System.Drawing.Size(108, 26);
            this.systemMenu.Text = "&Hệ Thống";
            // 
            // UsermanageMenuItem
            // 
            this.UsermanageMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.account_icon;
            this.UsermanageMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.UsermanageMenuItem.Name = "UsermanageMenuItem";
            this.UsermanageMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.UsermanageMenuItem.Size = new System.Drawing.Size(299, 26);
            this.UsermanageMenuItem.Text = "&Quản lý tài khoản";
            this.UsermanageMenuItem.Click += new System.EventHandler(this.UsermanageMenuItem_Click);
            // 
            // ChangePasswdMenuItem
            // 
            this.ChangePasswdMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.key_icon;
            this.ChangePasswdMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ChangePasswdMenuItem.Name = "ChangePasswdMenuItem";
            this.ChangePasswdMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ChangePasswdMenuItem.Size = new System.Drawing.Size(299, 26);
            this.ChangePasswdMenuItem.Text = "&Đổi mật khẩu";
            this.ChangePasswdMenuItem.Click += new System.EventHandler(this.ChangePasswdMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(296, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.exit_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.exitToolStripMenuItem.Text = "&Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // ManagerMenu
            // 
            this.ManagerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MedicineManageMenuItem,
            this.toolStripSeparator6,
            this.StoreManageMenuItem});
            this.ManagerMenu.Image = global::TT_LT.NET__BTL.Properties.Resources.manage_icon;
            this.ManagerMenu.Name = "ManagerMenu";
            this.ManagerMenu.Size = new System.Drawing.Size(93, 26);
            this.ManagerMenu.Text = "&Quản lý";
            // 
            // MedicineManageMenuItem
            // 
            this.MedicineManageMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.capsulesandpills;
            this.MedicineManageMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.MedicineManageMenuItem.Name = "MedicineManageMenuItem";
            this.MedicineManageMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.MedicineManageMenuItem.Size = new System.Drawing.Size(245, 26);
            this.MedicineManageMenuItem.Text = "&Thuốc";
            this.MedicineManageMenuItem.Click += new System.EventHandler(this.MedicineManageMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(242, 6);
            // 
            // StoreManageMenuItem
            // 
            this.StoreManageMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.pharmacy_icon;
            this.StoreManageMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.StoreManageMenuItem.Name = "StoreManageMenuItem";
            this.StoreManageMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.StoreManageMenuItem.Size = new System.Drawing.Size(245, 26);
            this.StoreManageMenuItem.Text = "&Cửa hàng";
            this.StoreManageMenuItem.Click += new System.EventHandler(this.StoreManageMenuItem_Click);
            // 
            // ReportMenu
            // 
            this.ReportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineReportMenuItem,
            this.toolStripSeparator1,
            this.StoreReportMenuItem});
            this.ReportMenu.Image = global::TT_LT.NET__BTL.Properties.Resources.report_icon;
            this.ReportMenu.Name = "ReportMenu";
            this.ReportMenu.Size = new System.Drawing.Size(97, 26);
            this.ReportMenu.Text = "&Báo cáo";
            // 
            // medicineReportMenuItem
            // 
            this.medicineReportMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.medicineReport;
            this.medicineReportMenuItem.Name = "medicineReportMenuItem";
            this.medicineReportMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.medicineReportMenuItem.Size = new System.Drawing.Size(234, 26);
            this.medicineReportMenuItem.Text = "&Thuốc";
            this.medicineReportMenuItem.Click += new System.EventHandler(this.medicineReportMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // StoreReportMenuItem
            // 
            this.StoreReportMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.storeReport;
            this.StoreReportMenuItem.Name = "StoreReportMenuItem";
            this.StoreReportMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.StoreReportMenuItem.Size = new System.Drawing.Size(234, 26);
            this.StoreReportMenuItem.Text = "&Cửa hàng";
            this.StoreReportMenuItem.Click += new System.EventHandler(this.StoreReportMenuItem_Click);
            // 
            // ExtentionMenu
            // 
            this.ExtentionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordMenuItem,
            this.toolStripSeparator2,
            this.exelMenuItem,
            this.toolStripSeparator4,
            this.paintMenuItem});
            this.ExtentionMenu.Image = global::TT_LT.NET__BTL.Properties.Resources.extension_icon;
            this.ExtentionMenu.Name = "ExtentionMenu";
            this.ExtentionMenu.Size = new System.Drawing.Size(94, 26);
            this.ExtentionMenu.Text = "&Tiện ích";
            // 
            // wordMenuItem
            // 
            this.wordMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.word;
            this.wordMenuItem.Name = "wordMenuItem";
            this.wordMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.wordMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wordMenuItem.Text = "&Word";
            this.wordMenuItem.Click += new System.EventHandler(this.wordMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // exelMenuItem
            // 
            this.exelMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.exel;
            this.exelMenuItem.Name = "exelMenuItem";
            this.exelMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exelMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exelMenuItem.Text = "&Exel";
            this.exelMenuItem.Click += new System.EventHandler(this.exelMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // paintMenuItem
            // 
            this.paintMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.painting_iconpng;
            this.paintMenuItem.Name = "paintMenuItem";
            this.paintMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.paintMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paintMenuItem.Text = "&Paint";
            this.paintMenuItem.Click += new System.EventHandler(this.paintMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorMenuItem,
            this.TutorialMenuItem,
            this.CopyrightMenuItem});
            this.HelpMenu.Image = global::TT_LT.NET__BTL.Properties.Resources.help_icon;
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(98, 26);
            this.HelpMenu.Text = "&Trợ giúp";
            // 
            // AuthorMenuItem
            // 
            this.AuthorMenuItem.Image = global::TT_LT.NET__BTL.Properties.Resources.about_us_icon;
            this.AuthorMenuItem.Name = "AuthorMenuItem";
            this.AuthorMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AuthorMenuItem.Text = "&Tác giả";
            this.AuthorMenuItem.Click += new System.EventHandler(this.AuthorMenuItem_Click);
            // 
            // TutorialMenuItem
            // 
            this.TutorialMenuItem.Name = "TutorialMenuItem";
            this.TutorialMenuItem.Size = new System.Drawing.Size(224, 26);
            this.TutorialMenuItem.Text = "&Hướng dẫn";
            this.TutorialMenuItem.Click += new System.EventHandler(this.TutorialMenuItem_Click);
            // 
            // CopyrightMenuItem
            // 
            this.CopyrightMenuItem.Name = "CopyrightMenuItem";
            this.CopyrightMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CopyrightMenuItem.Text = "&Bản quyền";
            this.CopyrightMenuItem.Click += new System.EventHandler(this.CopyrightMenuItem_Click);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackgroundImage = global::TT_LT.NET__BTL.Properties.Resources.logohomepage;
            this.panelMainContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMainContainer.Controls.Add(this.label2);
            this.panelMainContainer.Controls.Add(this.role);
            this.panelMainContainer.Controls.Add(this.label5);
            this.panelMainContainer.Controls.Add(this.fullname);
            this.panelMainContainer.Controls.Add(this.email);
            this.panelMainContainer.Controls.Add(this.label4);
            this.panelMainContainer.Controls.Add(this.label3);
            this.panelMainContainer.Controls.Add(this.username);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 30);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1302, 643);
            this.panelMainContainer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(889, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người dùng:";
            // 
            // role
            // 
            this.role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.role.Location = new System.Drawing.Point(1034, 108);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(82, 18);
            this.role.TabIndex = 8;
            this.role.Text = "UserRole";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(889, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên đăng nhập:";
            // 
            // fullname
            // 
            this.fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullname.AutoSize = true;
            this.fullname.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.fullname.Location = new System.Drawing.Point(1034, 18);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(120, 18);
            this.fullname.TabIndex = 5;
            this.fullname.Text = "UserFullname";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.email.Location = new System.Drawing.Point(1034, 78);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(90, 18);
            this.email.TabIndex = 7;
            this.email.Text = "UserEmail";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(889, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quyền:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(889, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.username.Location = new System.Drawing.Point(1034, 48);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(92, 18);
            this.username.TabIndex = 6;
            this.username.Text = "Username";
            // 
            // cuahangTableAdapter1
            // 
            this.cuahangTableAdapter1.ClearBeforeFill = true;
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 673);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1320, 720);
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParent_FormClosed);
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem systemMenu;
        private System.Windows.Forms.ToolStripMenuItem UsermanageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagerMenu;
        private System.Windows.Forms.ToolStripMenuItem MedicineManageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StoreManageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportMenu;
        private System.Windows.Forms.ToolStripMenuItem StoreReportMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem medicineReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExtentionMenu;
        private System.Windows.Forms.ToolStripMenuItem wordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AuthorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TutorialMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyrightMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private cuahangDataSetTableAdapters.cuahangTableAdapter cuahangTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label username;
    }
}



