namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmEmploiDuTemps
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
            this.lblJour = new System.Windows.Forms.Label();
            this.cbJour = new System.Windows.Forms.ComboBox();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.lblHeureFin = new System.Windows.Forms.Label();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.lblSalle = new System.Windows.Forms.Label();
            this.txtSalle = new System.Windows.Forms.TextBox();
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
            this.dgEmploi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRJour = new System.Windows.Forms.Label();
            this.txtRJour = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmploi)).BeginInit();
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
            this.lblTitle.Text = "   Emploi du Temps";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Bottom) | (System.Windows.Forms.AnchorStyles.Left))));
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelForm.Controls.Add(this.lblJour);
            this.panelForm.Controls.Add(this.cbJour);
            this.panelForm.Controls.Add(this.lblHeureDebut);
            this.panelForm.Controls.Add(this.txtHeureDebut);
            this.panelForm.Controls.Add(this.lblHeureFin);
            this.panelForm.Controls.Add(this.txtHeureFin);
            this.panelForm.Controls.Add(this.lblSalle);
            this.panelForm.Controls.Add(this.txtSalle);
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
            // lblJour
            // 
            this.lblJour.AutoSize = true;
            this.lblJour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJour.Location = new System.Drawing.Point(15, 15);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(45, 23);
            this.lblJour.Text = "Jour";
            // 
            // cbJour
            // 
            this.cbJour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbJour.Items.AddRange(new object[] { "Selectionner", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" });
            this.cbJour.Location = new System.Drawing.Point(15, 40);
            this.cbJour.Name = "cbJour";
            this.cbJour.Size = new System.Drawing.Size(365, 31);
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeureDebut.Location = new System.Drawing.Point(15, 82);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(110, 23);
            this.lblHeureDebut.Text = "Heure Debut";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeureDebut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHeureDebut.Location = new System.Drawing.Point(15, 107);
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(365, 30);
            // 
            // lblHeureFin
            // 
            this.lblHeureFin.AutoSize = true;
            this.lblHeureFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeureFin.Location = new System.Drawing.Point(15, 147);
            this.lblHeureFin.Name = "lblHeureFin";
            this.lblHeureFin.Size = new System.Drawing.Size(85, 23);
            this.lblHeureFin.Text = "Heure Fin";
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeureFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHeureFin.Location = new System.Drawing.Point(15, 172);
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(365, 30);
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSalle.Location = new System.Drawing.Point(15, 212);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(50, 23);
            this.lblSalle.Text = "Salle";
            // 
            // txtSalle
            // 
            this.txtSalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalle.Location = new System.Drawing.Point(15, 237);
            this.txtSalle.Name = "txtSalle";
            this.txtSalle.Size = new System.Drawing.Size(365, 30);
            // 
            // lblProfesseur
            // 
            this.lblProfesseur.AutoSize = true;
            this.lblProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfesseur.Location = new System.Drawing.Point(15, 280);
            this.lblProfesseur.Name = "lblProfesseur";
            this.lblProfesseur.Size = new System.Drawing.Size(90, 23);
            this.lblProfesseur.Text = "Professeur";
            // 
            // cbProfesseur
            // 
            this.cbProfesseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProfesseur.Location = new System.Drawing.Point(15, 305);
            this.cbProfesseur.Name = "cbProfesseur";
            this.cbProfesseur.Size = new System.Drawing.Size(365, 31);
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatiere.Location = new System.Drawing.Point(15, 347);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(65, 23);
            this.lblMatiere.Text = "Matiere";
            // 
            // cbMatiere
            // 
            this.cbMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMatiere.Location = new System.Drawing.Point(15, 372);
            this.cbMatiere.Name = "cbMatiere";
            this.cbMatiere.Size = new System.Drawing.Size(365, 31);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClasse.Location = new System.Drawing.Point(15, 414);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(55, 23);
            this.lblClasse.Text = "Classe";
            // 
            // cbClasse
            // 
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbClasse.Location = new System.Drawing.Point(15, 439);
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
            this.btnAjouter.Location = new System.Drawing.Point(15, 495);
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
            this.btnModifier.Location = new System.Drawing.Point(140, 495);
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
            this.btnSupprimer.Location = new System.Drawing.Point(265, 495);
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
            // dgEmploi
            // 
            this.dgEmploi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Bottom)) | (System.Windows.Forms.AnchorStyles.Left)) | (System.Windows.Forms.AnchorStyles.Right)));
            this.dgEmploi.AllowUserToAddRows = false;
            this.dgEmploi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmploi.BackgroundColor = System.Drawing.Color.White;
            this.dgEmploi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgEmploi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmploi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmploi.EnableHeadersVisualStyles = false;
            this.dgEmploi.Location = new System.Drawing.Point(420, 110);
            this.dgEmploi.Name = "dgEmploi";
            this.dgEmploi.ReadOnly = true;
            this.dgEmploi.RowHeadersVisible = false;
            this.dgEmploi.RowHeadersWidth = 62;
            this.dgEmploi.RowTemplate.Height = 35;
            this.dgEmploi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmploi.Size = new System.Drawing.Size(960, 575);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top) | (System.Windows.Forms.AnchorStyles.Left)) | (System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lblRJour);
            this.panel1.Controls.Add(this.txtRJour);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Location = new System.Drawing.Point(420, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 45);
            // 
            // lblRJour
            // 
            this.lblRJour.AutoSize = true;
            this.lblRJour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRJour.Location = new System.Drawing.Point(10, 10);
            this.lblRJour.Name = "lblRJour";
            this.lblRJour.Size = new System.Drawing.Size(45, 23);
            this.lblRJour.Text = "Jour";
            // 
            // txtRJour
            // 
            this.txtRJour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRJour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRJour.Location = new System.Drawing.Point(60, 8);
            this.txtRJour.Name = "txtRJour";
            this.txtRJour.Size = new System.Drawing.Size(250, 30);
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
            // frmEmploiDuTemps
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
            this.Controls.Add(this.dgEmploi);
            this.Name = "frmEmploiDuTemps";
            this.Text = "ClassLog - Emploi du Temps";
            this.Load += new System.EventHandler(this.frmEmploiDuTemps_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmploi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblJour;
        private System.Windows.Forms.ComboBox cbJour;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label lblHeureFin;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.Label lblSalle;
        private System.Windows.Forms.TextBox txtSalle;
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
        private System.Windows.Forms.DataGridView dgEmploi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRJour;
        private System.Windows.Forms.TextBox txtRJour;
        private System.Windows.Forms.Button btnRechercher;
    }
}
