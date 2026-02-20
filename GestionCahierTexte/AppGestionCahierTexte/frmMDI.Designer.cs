namespace AppGestionCahierTexte
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelSidebarMenu = new System.Windows.Forms.Panel();
            this.panelSidebarHeader = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnToggleSidebar = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelSidebar.SuspendLayout();
            this.panelSidebarHeader.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.panelSidebar.Controls.Add(this.panelSidebarMenu);
            this.panelSidebar.Controls.Add(this.panelSidebarHeader);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 668);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelSidebarMenu
            // 
            this.panelSidebarMenu.AutoScroll = true;
            this.panelSidebarMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebarMenu.Location = new System.Drawing.Point(0, 100);
            this.panelSidebarMenu.Name = "panelSidebarMenu";
            this.panelSidebarMenu.Size = new System.Drawing.Size(240, 568);
            this.panelSidebarMenu.TabIndex = 1;
            // 
            // panelSidebarHeader
            // 
            this.panelSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelSidebarHeader.Controls.Add(this.lblAppName);
            this.panelSidebarHeader.Controls.Add(this.lblAppSubtitle);
            this.panelSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSidebarHeader.Name = "panelSidebarHeader";
            this.panelSidebarHeader.Size = new System.Drawing.Size(240, 100);
            this.panelSidebarHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(0, 15);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(240, 42);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "CLASSLOG";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(0, 58);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(240, 25);
            this.lblAppSubtitle.TabIndex = 1;
            this.lblAppSubtitle.Text = "Gestion Scolaire";
            this.lblAppSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.White;
            this.panelTopBar.Controls.Add(this.btnDeconnexion);
            this.panelTopBar.Controls.Add(this.lblUserInfo);
            this.panelTopBar.Controls.Add(this.btnToggleSidebar);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(240, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(844, 55);
            this.panelTopBar.TabIndex = 1;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblUserInfo.Location = new System.Drawing.Point(60, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(614, 55);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnToggleSidebar
            // 
            this.btnToggleSidebar.FlatAppearance.BorderSize = 0;
            this.btnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleSidebar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.btnToggleSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnToggleSidebar.Location = new System.Drawing.Point(10, 8);
            this.btnToggleSidebar.Name = "btnToggleSidebar";
            this.btnToggleSidebar.Size = new System.Drawing.Size(45, 40);
            this.btnToggleSidebar.TabIndex = 0;
            this.btnToggleSidebar.Text = "\uE700";
            this.btnToggleSidebar.Click += new System.EventHandler(this.btnToggleSidebar_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.Location = new System.Drawing.Point(700, 10);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(130, 35);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(240, 55);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(844, 583);
            this.panelContent.TabIndex = 2;
            // 
            // panelDashboard
            // 
            this.panelDashboard.AutoScroll = true;
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(240, 55);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(844, 583);
            this.panelDashboard.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblDate});
            this.statusStrip1.Location = new System.Drawing.Point(240, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 30);
            this.statusStrip1.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 24);
            this.lblStatus.Text = "Pret";
            // 
            // lblDate
            // 
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 24);
            this.lblDate.Spring = true;
            this.lblDate.Text = "";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 668);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelSidebar);
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "icone app.ico"));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassLog - Gestion Scolaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebarHeader.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelSidebarMenu;
        private System.Windows.Forms.Panel panelSidebarHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnToggleSidebar;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
    }
}