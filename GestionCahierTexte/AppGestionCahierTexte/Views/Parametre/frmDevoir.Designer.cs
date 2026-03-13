namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmDevoir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this.dtpDateCreation = new System.Windows.Forms.DateTimePicker();
            this.lblDateLimite = new System.Windows.Forms.Label();
            this.dtpDateLimite = new System.Windows.Forms.DateTimePicker();
            this.lblStatut = new System.Windows.Forms.Label();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.lblProfesseur = new System.Windows.Forms.Label();
            this.cbProfesseur = new System.Windows.Forms.ComboBox();
            this.lblMatiere = new System.Windows.Forms.Label();
            this.cbMatiere = new System.Windows.Forms.ComboBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgDevoir = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRTitre = new System.Windows.Forms.Label();
            this.txtRTitre = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevoir)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1400, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "   Gestion des Devoirs";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Bottom) | (System.Windows.Forms.AnchorStyles.Left))));
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelForm.Controls.Add(this.lblTitre);
            this.panelForm.Controls.Add(this.txtTitre);
            this.panelForm.Controls.Add(this.lblDescription);
            this.panelForm.Controls.Add(this.txtDescription);
            this.panelForm.Controls.Add(this.lblDateCreation);
            this.panelForm.Controls.Add(this.dtpDateCreation);
            this.panelForm.Controls.Add(this.lblDateLimite);
            this.panelForm.Controls.Add(this.dtpDateLimite);
            this.panelForm.Controls.Add(this.lblStatut);
            this.panelForm.Controls.Add(this.txtStatut);
            this.panelForm.Controls.Add(this.lblProfesseur);
            this.panelForm.Controls.Add(this.cbProfesseur);
            this.panelForm.Controls.Add(this.lblMatiere);
            this.panelForm.Controls.Add(this.cbMatiere);
            this.panelForm.Controls.Add(this.lblClasse);
            this.panelForm.Controls.Add(this.cbClasse);
            this.panelForm.Controls.Add(this.btnAjouter);
            this.panelForm.Controls.Add(this.btnModifier);
            this.panelForm.Controls.Add(this.btnSupprimer);
            this.panelForm.Location = new System.Drawing.Point(10, 60);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(400, 670);
            this.panelForm.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitre.Location = new System.Drawing.Point(15, 15);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(50, 23);
            this.lblTitre.Text = "Titre";
            // 
            // txtTitre
            // 
            this.txtTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitre.Location = new System.Drawing.Point(15, 40);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(365, 30);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(15, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 23);
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(15, 103);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(365, 80);
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.AutoSize = true;
            this.lblDateCreation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateCreation.Location = new System.Drawing.Point(15, 193);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.Size = new System.Drawing.Size(115, 23);
            this.lblDateCreation.Text = "Date Creation";
            // 
            // dtpDateCreation
            // 
            this.dtpDateCreation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateCreation.Location = new System.Drawing.Point(15, 218);
            this.dtpDateCreation.Name = "dtpDateCreation";
            this.dtpDateCreation.Size = new System.Drawing.Size(365, 30);
            // 
            // lblDateLimite
            // 
            this.lblDateLimite.AutoSize = true;
            this.lblDateLimite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateLimite.Location = new System.Drawing.Point(15, 256);
            this.lblDateLimite.Name = "lblDateLimite";
            this.lblDateLimite.Size = new System.Drawing.Size(100, 23);
            this.lblDateLimite.Text = "Date Limite";
            // 
            // dtpDateLimite
            // 
            this.dtpDateLimite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateLimite.Location = new System.Drawing.Point(15, 281);
            this.dtpDateLimite.Name = "dtpDateLimite";
            this.dtpDateLimite.Size = new System.Drawing.Size(365, 30);
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatut.Location = new System.Drawing.Point(15, 319);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(55, 23);
            this.lblStatut.Text = "Statut";
            // 
            // txtStatut
            // 
            this.txtStatut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStatut.Location = new System.Drawing.Point(15, 344);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.Size = new System.Drawing.Size(365, 30);
            // 
            // lblProfesseur
            // 
            this.lblProfesseur.AutoSize = true;
            this.lblProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfesseur.Location = new System.Drawing.Point(15, 382);
            this.lblProfesseur.Name = "lblProfesseur";
            this.lblProfesseur.Size = new System.Drawing.Size(90, 23);
            this.lblProfesseur.Text = "Professeur";
            // 
            // cbProfesseur
            // 
            this.cbProfesseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProfesseur.Location = new System.Drawing.Point(15, 407);
            this.cbProfesseur.Name = "cbProfesseur";
            this.cbProfesseur.Size = new System.Drawing.Size(365, 31);
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatiere.Location = new System.Drawing.Point(15, 445);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(65, 23);
            this.lblMatiere.Text = "Matiere";
            // 
            // cbMatiere
            // 
            this.cbMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMatiere.Location = new System.Drawing.Point(15, 470);
            this.cbMatiere.Name = "cbMatiere";
            this.cbMatiere.Size = new System.Drawing.Size(365, 31);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClasse.Location = new System.Drawing.Point(15, 508);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(55, 23);
            this.lblClasse.Text = "Classe";
            // 
            // cbClasse
            // 
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbClasse.Location = new System.Drawing.Point(15, 533);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(365, 31);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(15, 585);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 40);
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(140, 585);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(115, 40);
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(265, 585);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(115, 40);
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
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
            // dgDevoir
            // 
            this.dgDevoir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Bottom)) | (System.Windows.Forms.AnchorStyles.Left)) | (System.Windows.Forms.AnchorStyles.Right)));
            this.dgDevoir.AllowUserToAddRows = false;
            this.dgDevoir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDevoir.BackgroundColor = System.Drawing.Color.White;
            this.dgDevoir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgDevoir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDevoir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDevoir.EnableHeadersVisualStyles = false;
            this.dgDevoir.Location = new System.Drawing.Point(420, 110);
            this.dgDevoir.Name = "dgDevoir";
            this.dgDevoir.ReadOnly = true;
            this.dgDevoir.RowHeadersVisible = false;
            this.dgDevoir.RowHeadersWidth = 62;
            this.dgDevoir.RowTemplate.Height = 35;
            this.dgDevoir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDevoir.Size = new System.Drawing.Size(960, 575);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Left)) | (System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lblRTitre);
            this.panel1.Controls.Add(this.txtRTitre);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Location = new System.Drawing.Point(420, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 45);
            // 
            // lblRTitre
            // 
            this.lblRTitre.AutoSize = true;
            this.lblRTitre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRTitre.Location = new System.Drawing.Point(10, 10);
            this.lblRTitre.Name = "lblRTitre";
            this.lblRTitre.Size = new System.Drawing.Size(50, 23);
            this.lblRTitre.Text = "Titre";
            // 
            // txtRTitre
            // 
            this.txtRTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRTitre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRTitre.Location = new System.Drawing.Point(65, 8);
            this.txtRTitre.Name = "txtRTitre";
            this.txtRTitre.Size = new System.Drawing.Size(250, 30);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
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
            // frmDevoir
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
            this.Controls.Add(this.dgDevoir);
            this.Name = "frmDevoir";
            this.Text = "ClassLog - Gestion des Devoirs";
            this.Load += new System.EventHandler(this.frmDevoir_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevoir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDateCreation;
        private System.Windows.Forms.DateTimePicker dtpDateCreation;
        private System.Windows.Forms.Label lblDateLimite;
        private System.Windows.Forms.DateTimePicker dtpDateLimite;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.TextBox txtStatut;
        private System.Windows.Forms.Label lblProfesseur;
        private System.Windows.Forms.ComboBox cbProfesseur;
        private System.Windows.Forms.Label lblMatiere;
        private System.Windows.Forms.ComboBox cbMatiere;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgDevoir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRTitre;
        private System.Windows.Forms.TextBox txtRTitre;
        private System.Windows.Forms.Button btnRechercher;
    }
}
