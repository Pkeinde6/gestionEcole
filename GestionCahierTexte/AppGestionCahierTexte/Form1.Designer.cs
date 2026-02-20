namespace AppGestionCahierTexte
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotdePasse = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelLeft.Controls.Add(this.lblAppSubtitle);
            this.panelLeft.Controls.Add(this.lblAppTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(350, 500);
            this.panelLeft.TabIndex = 10;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 150);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(310, 90);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "ClassLog";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(20, 250);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(310, 40);
            this.lblAppSubtitle.TabIndex = 1;
            this.lblAppSubtitle.Text = "Plateforme de gestion scolaire";
            this.lblAppSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panelRight.Controls.Add(this.lblConnexion);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.txtIdentifiant);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.txtMotdePasse);
            this.panelRight.Controls.Add(this.btnConnecter);
            this.panelRight.Controls.Add(this.btnQuitter);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(350, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(450, 500);
            this.panelRight.TabIndex = 11;
            // 
            // lblConnexion
            // 
            this.lblConnexion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblConnexion.Location = new System.Drawing.Point(30, 40);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(390, 50);
            this.lblConnexion.TabIndex = 10;
            this.lblConnexion.Text = "Connexion";
            this.lblConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(50, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIdentifiant.Location = new System.Drawing.Point(50, 155);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(350, 34);
            this.txtIdentifiant.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(50, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // txtMotdePasse
            // 
            this.txtMotdePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotdePasse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMotdePasse.Location = new System.Drawing.Point(50, 255);
            this.txtMotdePasse.Name = "txtMotdePasse";
            this.txtMotdePasse.PasswordChar = '*';
            this.txtMotdePasse.Size = new System.Drawing.Size(350, 34);
            this.txtMotdePasse.TabIndex = 3;
            // 
            // btnConnecter
            // 
            this.btnConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnecter.FlatAppearance.BorderSize = 0;
            this.btnConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnecter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConnecter.ForeColor = System.Drawing.Color.White;
            this.btnConnecter.Location = new System.Drawing.Point(50, 340);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(170, 50);
            this.btnConnecter.TabIndex = 4;
            this.btnConnecter.Text = "Se Connecter";
            this.btnConnecter.UseVisualStyleBackColor = false;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(230, 340);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(170, 50);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "icone app.ico"));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassLog :: Connexion";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotdePasse;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Button btnQuitter;
    }
}

