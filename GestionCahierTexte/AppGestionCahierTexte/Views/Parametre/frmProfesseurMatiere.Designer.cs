namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmProfesseurMatiere
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblProfesseur = new System.Windows.Forms.Label();
            this.cbProfesseur = new System.Windows.Forms.ComboBox();
            this.lblMatiere = new System.Windows.Forms.Label();
            this.cbMatiere = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgAffectation = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRProfesseur = new System.Windows.Forms.Label();
            this.txtRProfesseur = new System.Windows.Forms.TextBox();
            this.lblRMatiere = new System.Windows.Forms.Label();
            this.txtRMatiere = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAffectation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1400, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "   Affectation Matieres - Professeurs";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Bottom) | (System.Windows.Forms.AnchorStyles.Left))));
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelForm.Controls.Add(this.lblProfesseur);
            this.panelForm.Controls.Add(this.cbProfesseur);
            this.panelForm.Controls.Add(this.lblMatiere);
            this.panelForm.Controls.Add(this.cbMatiere);
            this.panelForm.Controls.Add(this.btnAjouter);
            this.panelForm.Controls.Add(this.btnSupprimer);
            this.panelForm.Location = new System.Drawing.Point(10, 60);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(400, 670);
            this.panelForm.TabIndex = 1;
            // 
            // lblProfesseur
            // 
            this.lblProfesseur.AutoSize = true;
            this.lblProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfesseur.Location = new System.Drawing.Point(15, 20);
            this.lblProfesseur.Name = "lblProfesseur";
            this.lblProfesseur.Size = new System.Drawing.Size(90, 23);
            this.lblProfesseur.Text = "Professeur";
            // 
            // cbProfesseur
            // 
            this.cbProfesseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProfesseur.Location = new System.Drawing.Point(15, 47);
            this.cbProfesseur.Name = "cbProfesseur";
            this.cbProfesseur.Size = new System.Drawing.Size(365, 31);
            this.cbProfesseur.SelectedIndexChanged += new System.EventHandler(this.cbProfesseur_SelectedIndexChanged);
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatiere.Location = new System.Drawing.Point(15, 95);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(65, 23);
            this.lblMatiere.Text = "Matiere";
            // 
            // cbMatiere
            // 
            this.cbMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMatiere.Location = new System.Drawing.Point(15, 122);
            this.cbMatiere.Name = "cbMatiere";
            this.cbMatiere.Size = new System.Drawing.Size(365, 31);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(15, 180);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(175, 40);
            this.btnAjouter.Text = "Affecter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(68)))), ((int)(((byte)(56)))));
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(200, 180);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(180, 40);
            this.btnSupprimer.Text = "Retirer Affectation";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.btnSelectionner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectionner.FlatAppearance.BorderSize = 0;
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(420, 695);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(150, 40);
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // dgAffectation
            // 
            this.dgAffectation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Bottom)) | (System.Windows.Forms.AnchorStyles.Left)) | (System.Windows.Forms.AnchorStyles.Right)));
            this.dgAffectation.AllowUserToAddRows = false;
            this.dgAffectation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAffectation.BackgroundColor = System.Drawing.Color.White;
            this.dgAffectation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAffectation.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.dgAffectation.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgAffectation.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgAffectation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAffectation.EnableHeadersVisualStyles = false;
            this.dgAffectation.Location = new System.Drawing.Point(420, 110);
            this.dgAffectation.Name = "dgAffectation";
            this.dgAffectation.ReadOnly = true;
            this.dgAffectation.RowHeadersVisible = false;
            this.dgAffectation.RowHeadersWidth = 62;
            this.dgAffectation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAffectation.Size = new System.Drawing.Size(960, 575);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Left)) | (System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lblRProfesseur);
            this.panel1.Controls.Add(this.txtRProfesseur);
            this.panel1.Controls.Add(this.lblRMatiere);
            this.panel1.Controls.Add(this.txtRMatiere);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Location = new System.Drawing.Point(420, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 45);
            // 
            // lblRProfesseur
            // 
            this.lblRProfesseur.AutoSize = true;
            this.lblRProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRProfesseur.Location = new System.Drawing.Point(10, 10);
            this.lblRProfesseur.Name = "lblRProfesseur";
            this.lblRProfesseur.Size = new System.Drawing.Size(90, 23);
            this.lblRProfesseur.Text = "Professeur";
            // 
            // txtRProfesseur
            // 
            this.txtRProfesseur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRProfesseur.Location = new System.Drawing.Point(110, 8);
            this.txtRProfesseur.Name = "txtRProfesseur";
            this.txtRProfesseur.Size = new System.Drawing.Size(200, 30);
            // 
            // lblRMatiere
            // 
            this.lblRMatiere.AutoSize = true;
            this.lblRMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRMatiere.Location = new System.Drawing.Point(330, 10);
            this.lblRMatiere.Name = "lblRMatiere";
            this.lblRMatiere.Size = new System.Drawing.Size(65, 23);
            this.lblRMatiere.Text = "Matiere";
            // 
            // txtRMatiere
            // 
            this.txtRMatiere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRMatiere.Location = new System.Drawing.Point(405, 8);
            this.txtRMatiere.Name = "txtRMatiere";
            this.txtRMatiere.Size = new System.Drawing.Size(200, 30);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(840, 5);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(110, 35);
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // frmProfesseurMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 740);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgAffectation);
            this.Name = "frmProfesseurMatiere";
            this.Text = "ClassLog - Affectation Matieres Professeurs";
            this.Load += new System.EventHandler(this.frmProfesseurMatiere_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAffectation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblProfesseur;
        private System.Windows.Forms.ComboBox cbProfesseur;
        private System.Windows.Forms.Label lblMatiere;
        private System.Windows.Forms.ComboBox cbMatiere;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgAffectation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRProfesseur;
        private System.Windows.Forms.TextBox txtRProfesseur;
        private System.Windows.Forms.Label lblRMatiere;
        private System.Windows.Forms.TextBox txtRMatiere;
        private System.Windows.Forms.Button btnRechercher;
    }
}
