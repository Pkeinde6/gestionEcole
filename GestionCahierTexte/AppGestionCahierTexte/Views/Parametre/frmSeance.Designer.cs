namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmSeance
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.lblHeureFin = new System.Windows.Forms.Label();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.lblContenu = new System.Windows.Forms.Label();
            this.txtContenu = new System.Windows.Forms.TextBox();
            this.lblObservation = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRContenu = new System.Windows.Forms.Label();
            this.txtRContenu = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dgSeance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeance)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1400, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "   Gestion des Seances";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.lblDate);
            this.panelForm.Controls.Add(this.dtpDate);
            this.panelForm.Controls.Add(this.lblHeureDebut);
            this.panelForm.Controls.Add(this.txtHeureDebut);
            this.panelForm.Controls.Add(this.lblHeureFin);
            this.panelForm.Controls.Add(this.txtHeureFin);
            this.panelForm.Controls.Add(this.lblContenu);
            this.panelForm.Controls.Add(this.txtContenu);
            this.panelForm.Controls.Add(this.lblObservation);
            this.panelForm.Controls.Add(this.txtObservation);
            this.panelForm.Controls.Add(this.lblProfesseur);
            this.panelForm.Controls.Add(this.cbProfesseur);
            this.panelForm.Controls.Add(this.lblMatiere);
            this.panelForm.Controls.Add(this.cbMatiere);
            this.panelForm.Controls.Add(this.lblClasse);
            this.panelForm.Controls.Add(this.cbClasse);
            this.panelForm.Controls.Add(this.btnAjouter);
            this.panelForm.Controls.Add(this.btnModifier);
            this.panelForm.Controls.Add(this.btnSupprimer);
            this.panelForm.Location = new System.Drawing.Point(12, 55);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(10);
            this.panelForm.Size = new System.Drawing.Size(400, 620);
            this.panelForm.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblDate.Location = new System.Drawing.Point(15, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(15, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(370, 30);
            this.dtpDate.TabIndex = 1;
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeureDebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblHeureDebut.Location = new System.Drawing.Point(15, 72);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(110, 25);
            this.lblHeureDebut.TabIndex = 2;
            this.lblHeureDebut.Text = "Heure Debut";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeureDebut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHeureDebut.Location = new System.Drawing.Point(15, 97);
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(170, 30);
            this.txtHeureDebut.TabIndex = 3;
            // 
            // lblHeureFin
            // 
            this.lblHeureFin.AutoSize = true;
            this.lblHeureFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeureFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblHeureFin.Location = new System.Drawing.Point(200, 72);
            this.lblHeureFin.Name = "lblHeureFin";
            this.lblHeureFin.Size = new System.Drawing.Size(85, 25);
            this.lblHeureFin.TabIndex = 4;
            this.lblHeureFin.Text = "Heure Fin";
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeureFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHeureFin.Location = new System.Drawing.Point(200, 97);
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(185, 30);
            this.txtHeureFin.TabIndex = 5;
            // 
            // lblContenu
            // 
            this.lblContenu.AutoSize = true;
            this.lblContenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblContenu.Location = new System.Drawing.Point(15, 135);
            this.lblContenu.Name = "lblContenu";
            this.lblContenu.Size = new System.Drawing.Size(77, 25);
            this.lblContenu.TabIndex = 6;
            this.lblContenu.Text = "Contenu";
            // 
            // txtContenu
            // 
            this.txtContenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContenu.Location = new System.Drawing.Point(15, 160);
            this.txtContenu.Multiline = true;
            this.txtContenu.Name = "txtContenu";
            this.txtContenu.Size = new System.Drawing.Size(370, 55);
            this.txtContenu.TabIndex = 7;
            // 
            // lblObservation
            // 
            this.lblObservation.AutoSize = true;
            this.lblObservation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblObservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblObservation.Location = new System.Drawing.Point(15, 222);
            this.lblObservation.Name = "lblObservation";
            this.lblObservation.Size = new System.Drawing.Size(105, 25);
            this.lblObservation.TabIndex = 8;
            this.lblObservation.Text = "Observation";
            // 
            // txtObservation
            // 
            this.txtObservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservation.Location = new System.Drawing.Point(15, 247);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(370, 55);
            this.txtObservation.TabIndex = 9;
            // 
            // lblProfesseur
            // 
            this.lblProfesseur.AutoSize = true;
            this.lblProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfesseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblProfesseur.Location = new System.Drawing.Point(15, 310);
            this.lblProfesseur.Name = "lblProfesseur";
            this.lblProfesseur.Size = new System.Drawing.Size(93, 25);
            this.lblProfesseur.TabIndex = 10;
            this.lblProfesseur.Text = "Professeur";
            // 
            // cbProfesseur
            // 
            this.cbProfesseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProfesseur.FormattingEnabled = true;
            this.cbProfesseur.Location = new System.Drawing.Point(15, 335);
            this.cbProfesseur.Name = "cbProfesseur";
            this.cbProfesseur.Size = new System.Drawing.Size(370, 31);
            this.cbProfesseur.TabIndex = 11;
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatiere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblMatiere.Location = new System.Drawing.Point(15, 373);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(71, 25);
            this.lblMatiere.TabIndex = 12;
            this.lblMatiere.Text = "Matiere";
            // 
            // cbMatiere
            // 
            this.cbMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMatiere.FormattingEnabled = true;
            this.cbMatiere.Location = new System.Drawing.Point(15, 398);
            this.cbMatiere.Name = "cbMatiere";
            this.cbMatiere.Size = new System.Drawing.Size(370, 31);
            this.cbMatiere.TabIndex = 13;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblClasse.Location = new System.Drawing.Point(15, 436);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(59, 25);
            this.lblClasse.TabIndex = 14;
            this.lblClasse.Text = "Classe";
            // 
            // cbClasse
            // 
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(15, 461);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(370, 31);
            this.cbClasse.TabIndex = 15;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(15, 510);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(370, 40);
            this.btnAjouter.TabIndex = 16;
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
            this.btnModifier.Location = new System.Drawing.Point(15, 560);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(180, 40);
            this.btnModifier.TabIndex = 17;
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
            this.btnSupprimer.Location = new System.Drawing.Point(205, 560);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(180, 40);
            this.btnSupprimer.TabIndex = 18;
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
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(12, 685);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(400, 35);
            this.btnSelectionner.TabIndex = 19;
            this.btnSelectionner.Text = "Selectionner la ligne";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblRContenu);
            this.panel1.Controls.Add(this.txtRContenu);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Location = new System.Drawing.Point(425, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 60);
            this.panel1.TabIndex = 20;
            // 
            // lblRContenu
            // 
            this.lblRContenu.AutoSize = true;
            this.lblRContenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRContenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.lblRContenu.Location = new System.Drawing.Point(15, 18);
            this.lblRContenu.Name = "lblRContenu";
            this.lblRContenu.Size = new System.Drawing.Size(67, 20);
            this.lblRContenu.TabIndex = 0;
            this.lblRContenu.Text = "Contenu";
            // 
            // txtRContenu
            // 
            this.txtRContenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRContenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRContenu.Location = new System.Drawing.Point(90, 14);
            this.txtRContenu.Name = "txtRContenu";
            this.txtRContenu.Size = new System.Drawing.Size(400, 30);
            this.txtRContenu.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(770, 10);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(170, 40);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // dgSeance
            // 
            this.dgSeance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSeance.AllowUserToAddRows = false;
            this.dgSeance.AllowUserToDeleteRows = false;
            this.dgSeance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSeance.BackgroundColor = System.Drawing.Color.White;
            this.dgSeance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSeance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgSeance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSeance.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.dgSeance.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgSeance.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgSeance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeance.EnableHeadersVisualStyles = false;
            this.dgSeance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(236)))));
            this.dgSeance.Location = new System.Drawing.Point(425, 125);
            this.dgSeance.Name = "dgSeance";
            this.dgSeance.ReadOnly = true;
            this.dgSeance.RowHeadersVisible = false;
            this.dgSeance.RowHeadersWidth = 62;
            this.dgSeance.RowTemplate.Height = 35;
            this.dgSeance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSeance.Size = new System.Drawing.Size(960, 600);
            this.dgSeance.TabIndex = 21;
            // 
            // frmSeance
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
            this.Controls.Add(this.dgSeance);
            this.Name = "frmSeance";
            this.Text = "Seances";
            this.Load += new System.EventHandler(this.frmSeance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSeance)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label lblHeureFin;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.Label lblContenu;
        private System.Windows.Forms.TextBox txtContenu;
        private System.Windows.Forms.Label lblObservation;
        private System.Windows.Forms.TextBox txtObservation;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRContenu;
        private System.Windows.Forms.TextBox txtRContenu;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgSeance;
    }
}
