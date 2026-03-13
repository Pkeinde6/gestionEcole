using AppGestionCahierTexte.Views.Securite;
using AppGestionCahierTexte.Views.Parametre;
using AppGestionCahierTexte.Model;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCahierTexte
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                // Double buffering + rendu optimisé pour performance max (uniquement à l'exécution)
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                this.UpdateStyles();

                try { this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "icone app.ico")); } catch { }
                this.Resize += (s, e) => { if (panelDashboard.Visible) ShowDashboard(); };
            }
        }

        // Activer composition WS_EX_COMPOSITED pour tous les contrôles enfants
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!DesignMode)
                    cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public string Profil;
        public int UtilisateurId;
        public string UtilisateurNom;

        private bool sidebarExpanded = true;
        private Button activeSidebarButton = null;
        private Color sidebarBg = Color.FromArgb(35, 35, 45);
        private Color sidebarHover = Color.FromArgb(55, 55, 65);
        private Color sidebarActive = Color.FromArgb(230, 85, 85);

        // ===== SIDEBAR TOGGLE =====
        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            sidebarExpanded = !sidebarExpanded;
            panelSidebar.Width = sidebarExpanded ? 240 : 60;
            lblAppName.Visible = sidebarExpanded;
            lblAppSubtitle.Visible = sidebarExpanded;

            foreach (Control c in panelSidebarMenu.Controls)
            {
                if (c is Button btn)
                {
                    btn.Size = new Size(sidebarExpanded ? 240 : 60, 44);
                    btn.Invalidate();
                }
                else if (c is Label lbl && lbl.Tag != null && lbl.Tag.ToString() == "section")
                {
                    lbl.Visible = sidebarExpanded;
                }
            }

            if (panelDashboard.Visible) ShowDashboard();
        }

        private string GetIcon(string tag)
        {
            if (tag == null) return "";
            if (tag.Contains("Dashboard")) return "\uE80F";
            if (tag.Contains("Affect")) return "\uE735";
            if (tag.Contains("Matiere")) return "\uE7BC";
            if (tag.Contains("Classe")) return "\uE7BE";
            if (tag.Contains("Professeur")) return "\uE77B";
            if (tag.Contains("Departement")) return "\uEC06";
            if (tag.Contains("Resp")) return "\uEA18";
            if (tag.Contains("Seance")) return "\uE787";
            if (tag.Contains("Devoir")) return "\uF0E3";
            if (tag.Contains("Emploi")) return "\uE823";
            if (tag.Contains("Quitter")) return "\uE7E8";
            return "\uE7C3";
        }

        // ===== BUILD SIDEBAR =====
        private void BuildSidebar()
        {
            panelSidebarMenu.Controls.Clear();
            int y = 10;

            // Dashboard button  
            y = AddSidebarButton("\uE80F", "Dashboard", "Dashboard", y, (s, e) => { ShowDashboard(); SetActiveButton((Button)s); });

            // --- Parametre section (Admin / Chef only) ---
            if (Profil == "Administrateur" || Profil == "ChefDepartement")
            {
                y = AddSidebarSection("PARAMETRES", y);
                y = AddSidebarButton("\uE7BC", "Matieres", "Matiere", y, (s, e) => { OpenChildForm(new frmMatiere()); SetActiveButton((Button)s); });
                y = AddSidebarButton("\uE7BE", "Classes", "Classe", y, (s, e) => { OpenChildForm(new frmClasse()); SetActiveButton((Button)s); });
                y = AddSidebarButton("\uE77B", "Professeurs", "Professeur", y, (s, e) => { OpenChildForm(new frmProfesseur()); SetActiveButton((Button)s); });
                y = AddSidebarButton("\uEC06", "Departements", "Departement", y, (s, e) => { OpenChildForm(new frmDepartement()); SetActiveButton((Button)s); });
                y = AddSidebarButton("\uE735", "Affect. Matieres", "Affect. Matieres", y, (s, e) => { OpenChildForm(new frmProfesseurMatiere()); SetActiveButton((Button)s); });
            }

            // --- Securite section (Admin / Chef only) ---
            if (Profil == "Administrateur" || Profil == "ChefDepartement")
            {
                y = AddSidebarSection("SECURITE", y);
                y = AddSidebarButton("\uEA18", "Resp. Classe", "Resp. Classe", y, (s, e) => { OpenChildForm(new frmResponsableClasse()); SetActiveButton((Button)s); });
            }

            // --- Cahier de texte
            y = AddSidebarSection("CAHIER DE TEXTE", y);
            y = AddSidebarButton("\uE787", "Seances", "Seance", y, (s, e) => { OpenChildForm(new frmSeance()); SetActiveButton((Button)s); });
            y = AddSidebarButton("\uF0E3", "Devoirs", "Devoir", y, (s, e) => { OpenChildForm(new frmDevoir()); SetActiveButton((Button)s); });
            y = AddSidebarButton("\uE823", "Emploi du Temps", "Emploi du Temps", y, (s, e) => { OpenChildForm(new frmEmploiDuTemps()); SetActiveButton((Button)s); });

            // --- Actions ---
            y += 20;
            y = AddSidebarButton("\uE7E8", "Quitter", "Quitter", y, (s, e) => { Application.Exit(); });
        }

        private int AddSidebarButton(string iconGlyph, string text, string tag, int y, EventHandler click)
        {
            Button btn = new Button();
            btn.Text = "";
            btn.Tag = tag;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = sidebarHover;
            btn.BackColor = sidebarBg;
            btn.ForeColor = Color.FromArgb(190, 190, 200);
            btn.Size = new Size(240, 44);
            btn.Location = new Point(0, y);
            btn.Cursor = Cursors.Hand;
            btn.Click += click;
            btn.MouseEnter += (s, e) => { if (btn != activeSidebarButton) btn.BackColor = sidebarHover; };
            btn.MouseLeave += (s, e) => { if (btn != activeSidebarButton) btn.BackColor = sidebarBg; };

            string ic = iconGlyph;
            string tx = text;
            btn.Paint += (s, pe) =>
            {
                var b = (Button)s;
                pe.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                using (var iconFont = new Font("Segoe MDL2 Assets", 13F))
                using (var textFont = new Font("Segoe UI", 10.5F))
                {
                    if (sidebarExpanded)
                    {
                        TextRenderer.DrawText(pe.Graphics, ic, iconFont, new Point(18, (b.Height - 18) / 2), b.ForeColor);
                        TextRenderer.DrawText(pe.Graphics, tx, textFont, new Point(50, (b.Height - 18) / 2), b.ForeColor);
                    }
                    else
                    {
                        var sz = TextRenderer.MeasureText(ic, iconFont);
                        TextRenderer.DrawText(pe.Graphics, ic, iconFont, new Point((b.Width - sz.Width) / 2, (b.Height - sz.Height) / 2), b.ForeColor);
                    }
                }
            };

            panelSidebarMenu.Controls.Add(btn);
            return y + 44;
        }

        private int AddSidebarSection(string title, int y)
        {
            Label lbl = new Label();
            lbl.Text = title;
            lbl.Tag = "section";
            lbl.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(245, 185, 60);
            lbl.AutoSize = false;
            lbl.Size = new Size(240, 30);
            lbl.Location = new Point(0, y + 8);
            lbl.Padding = new Padding(22, 0, 0, 0);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            panelSidebarMenu.Controls.Add(lbl);
            return y + 38;
        }

        private void SetActiveButton(Button btn)
        {
            if (activeSidebarButton != null)
            {
                activeSidebarButton.BackColor = sidebarBg;
                activeSidebarButton.ForeColor = Color.FromArgb(190, 190, 200);
            }
            activeSidebarButton = btn;
            btn.BackColor = sidebarActive;
            btn.ForeColor = Color.White;
        }

        // ===== MDI CHILD OPEN =====
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form chform in charr) chform.Close();
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                fermer();
                panelDashboard.Visible = false;
                panelContent.Visible = false;
                childForm.MdiParent = this;
                childForm.Show();
                childForm.WindowState = FormWindowState.Maximized;
                childForm.FormClosed += (s, ev) => { if (this.MdiChildren.Length == 0) ShowDashboard(); };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture du formulaire : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowDashboard();
            }
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        // ===== DASHBOARD WITH WIDGETS =====
        private void ShowDashboard()
        {
            fermer();
            panelDashboard.Controls.Clear();
            panelDashboard.Visible = true;
            panelDashboard.BringToFront();
            panelContent.Visible = false;

            // Ensure MdiClient is behind the dashboard
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.SendToBack();
                    break;
                }
            }

            int nbClasses = 0, nbMatieres = 0, nbProfesseurs = 0, nbResponsables = 0, nbDepartements = 0, nbSeances = 0, nbDevoirs = 0, nbEmplois = 0, nbAffectations = 0;
            int mesSeances = 0, mesDevoirs = 0, mesMatieres = 0, mesClasses = 0;
            var prochainsCours = new List<dynamic>();
            var prochainsDevoirs = new List<dynamic>();

            try
            {
                using (var db = new BDCahierDeTexteContext())
                {
                    nbClasses = db.classes.Count();
                    nbMatieres = db.matieres.Count();
                    nbProfesseurs = db.profsseurs.Count();
                    nbResponsables = db.responsableClasses.Count();
                    nbDepartements = db.departements.Count();
                    nbSeances = db.seances.Count();
                    nbDevoirs = db.devoirs.Count();
                    nbEmplois = db.emploiDuTemps.Count();
                    nbAffectations = db.professeurMatieres.Count();

                    if (Profil == "Professeur" && UtilisateurId > 0)
                    {
                        mesSeances = db.seances.Count(s => s.IdProfesseur == UtilisateurId);
                        mesDevoirs = db.devoirs.Count(d => d.IdProfesseur == UtilisateurId);
                        mesMatieres = db.professeurMatieres.Count(pm => pm.IdProfesseur == UtilisateurId);
                        mesClasses = db.seances.Where(s => s.IdProfesseur == UtilisateurId).Select(s => s.IdClasse).Distinct().Count();

                        prochainsCours = db.emploiDuTemps
                            .Where(e => e.IdProfesseur == UtilisateurId)
                            .Select(e => new { e.JourSemaine, e.HeureDebut, e.HeureFin, Matiere = e.Matiere.DesignationMatiere, Classe = e.Classe.DesignationClasse, e.Salle })
                            .Take(5).ToList<dynamic>();

                        prochainsDevoirs = db.devoirs
                            .Where(d => d.IdProfesseur == UtilisateurId && d.DateLimite >= DateTime.Now)
                            .OrderBy(d => d.DateLimite)
                            .Select(d => new { d.Titre, d.DateLimite, Matiere = d.Matiere.DesignationMatiere, Classe = d.Classe.DesignationClasse })
                            .Take(5).ToList<dynamic>();
                    }
                }
            }
            catch { }

            int pw = panelDashboard.Width;
            int margin = 30;
            int spacing = 20;

            // ===== WELCOME BANNER (widget style) =====
            Panel bannerWidget = CreateWidget(pw - 2 * margin, 100);
            bannerWidget.Location = new Point(margin, 20);
            bannerWidget.BackColor = Color.FromArgb(230, 85, 85);

            Label lblWelcome = new Label();
            lblWelcome.Text = !string.IsNullOrEmpty(UtilisateurNom) ? "Bienvenue, " + UtilisateurNom + " !" : "Tableau de Bord";
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(25, 15);
            bannerWidget.Controls.Add(lblWelcome);

            Label lblProfilInfo = new Label();
            lblProfilInfo.Text = GetProfilDisplay(Profil) + "  |  " + DateTime.Now.ToString("dddd dd MMMM yyyy") + "  |  ClassLog";
            lblProfilInfo.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblProfilInfo.ForeColor = Color.FromArgb(255, 210, 210);
            lblProfilInfo.AutoSize = true;
            lblProfilInfo.Location = new Point(25, 60);
            bannerWidget.Controls.Add(lblProfilInfo);
            panelDashboard.Controls.Add(bannerWidget);

            // ===== STAT CARDS (widgets) =====
            var cards = new List<Tuple<string, string, Color, Color, string>>();

            if (Profil == "Administrateur" || Profil == "ChefDepartement")
            {
                cards.Add(Tuple.Create("Classes", nbClasses.ToString(), Color.FromArgb(230, 85, 85), Color.FromArgb(200, 70, 70), "\uE7BE"));
                cards.Add(Tuple.Create("Matieres", nbMatieres.ToString(), Color.FromArgb(245, 185, 60), Color.FromArgb(220, 165, 45), "\uE7BC"));
                cards.Add(Tuple.Create("Professeurs", nbProfesseurs.ToString(), Color.FromArgb(30, 190, 155), Color.FromArgb(25, 165, 135), "\uE77B"));
                cards.Add(Tuple.Create("Responsables", nbResponsables.ToString(), Color.FromArgb(230, 100, 150), Color.FromArgb(200, 80, 130), "\uEA18"));
                cards.Add(Tuple.Create("Departements", nbDepartements.ToString(), Color.FromArgb(35, 35, 45), Color.FromArgb(25, 25, 35), "\uEC06"));
                cards.Add(Tuple.Create("Seances", nbSeances.ToString(), Color.FromArgb(30, 190, 155), Color.FromArgb(25, 165, 135), "\uE787"));
                cards.Add(Tuple.Create("Devoirs", nbDevoirs.ToString(), Color.FromArgb(245, 185, 60), Color.FromArgb(220, 165, 45), "\uF0E3"));
                cards.Add(Tuple.Create("Emplois", nbEmplois.ToString(), Color.FromArgb(230, 85, 85), Color.FromArgb(200, 70, 70), "\uE823"));
                cards.Add(Tuple.Create("Affectations", nbAffectations.ToString(), Color.FromArgb(30, 190, 155), Color.FromArgb(25, 165, 135), "\uE735"));
            }
            else if (Profil == "Professeur")
            {
                cards.Add(Tuple.Create("Mes Matieres", mesMatieres.ToString(), Color.FromArgb(245, 185, 60), Color.FromArgb(220, 165, 45), "\uE7BC"));
                cards.Add(Tuple.Create("Mes Classes", mesClasses.ToString(), Color.FromArgb(230, 85, 85), Color.FromArgb(200, 70, 70), "\uE7BE"));
                cards.Add(Tuple.Create("Mes Seances", mesSeances.ToString(), Color.FromArgb(30, 190, 155), Color.FromArgb(25, 165, 135), "\uE787"));
                cards.Add(Tuple.Create("Mes Devoirs", mesDevoirs.ToString(), Color.FromArgb(230, 100, 150), Color.FromArgb(200, 80, 130), "\uF0E3"));
            }
            else
            {
                cards.Add(Tuple.Create("Seances", nbSeances.ToString(), Color.FromArgb(30, 190, 155), Color.FromArgb(25, 165, 135), "\uE787"));
                cards.Add(Tuple.Create("Classes", nbClasses.ToString(), Color.FromArgb(230, 85, 85), Color.FromArgb(200, 70, 70), "\uE7BE"));
                cards.Add(Tuple.Create("Matieres", nbMatieres.ToString(), Color.FromArgb(245, 185, 60), Color.FromArgb(220, 165, 45), "\uE7BC"));
                cards.Add(Tuple.Create("Devoirs", nbDevoirs.ToString(), Color.FromArgb(230, 100, 150), Color.FromArgb(200, 80, 130), "\uF0E3"));
            }

            int availableWidth = pw - 2 * margin;
            int cardsPerRow = Math.Max(1, Math.Min(cards.Count, (availableWidth + spacing) / (200 + spacing)));
            int cardWidth = (availableWidth - (cardsPerRow - 1) * spacing) / cardsPerRow;
            cardWidth = Math.Min(cardWidth, 260);
            int cardHeight = 120;
            int startY = 145;

            int totalCardsWidth = cardsPerRow * cardWidth + (cardsPerRow - 1) * spacing;
            int startX = margin;

            for (int i = 0; i < cards.Count; i++)
            {
                int row = i / cardsPerRow;
                int col = i % cardsPerRow;
                Panel card = CreateStatWidget(cards[i].Item1, cards[i].Item2, cards[i].Item5, cards[i].Item3, cards[i].Item4, cardWidth, cardHeight);
                card.Location = new Point(startX + col * (cardWidth + spacing), startY + row * (cardHeight + spacing));
                panelDashboard.Controls.Add(card);
            }

            int rows = (int)Math.Ceiling((double)cards.Count / cardsPerRow);
            int afterCardsY = startY + rows * (cardHeight + spacing) + 10;

            // ===== PROFESSOR: Emploi du temps + Devoirs widgets =====
            if (Profil == "Professeur" && UtilisateurId > 0)
            {
                int halfWidth = (availableWidth - spacing) / 2;

                // Emploi du temps widget
                Panel emploiWidget = CreateWidget(halfWidth, 280);
                emploiWidget.Location = new Point(margin, afterCardsY);
                Label lblEmploi = CreateWidgetTitle("Mon Emploi du Temps");
                emploiWidget.Controls.Add(lblEmploi);
                DataGridView dgEmploi = CreateWidgetGrid();
                dgEmploi.Location = new Point(10, 50);
                dgEmploi.Size = new Size(halfWidth - 20, 220);
                dgEmploi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
                dgEmploi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgEmploi.DataSource = prochainsCours;
                emploiWidget.Controls.Add(dgEmploi);
                panelDashboard.Controls.Add(emploiWidget);

                // Devoirs widget
                Panel devoirWidget = CreateWidget(halfWidth, 280);
                devoirWidget.Location = new Point(margin + halfWidth + spacing, afterCardsY);
                Label lblDevoirs = CreateWidgetTitle("Devoirs a Rendre");
                devoirWidget.Controls.Add(lblDevoirs);
                DataGridView dgDevoirs = CreateWidgetGrid();
                dgDevoirs.Location = new Point(10, 50);
                dgDevoirs.Size = new Size(halfWidth - 20, 220);
                dgDevoirs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 185, 60);
                dgDevoirs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgDevoirs.DataSource = prochainsDevoirs;
                devoirWidget.Controls.Add(dgDevoirs);
                panelDashboard.Controls.Add(devoirWidget);

                afterCardsY += 300;
            }

            // ===== QUICK ACCESS WIDGETS =====
            var quickAccess = new List<Tuple<string, string, Color, EventHandler>>();

            if (Profil == "Administrateur" || Profil == "ChefDepartement")
            {
                quickAccess.Add(Tuple.Create("\uE7BE", "Classes", Color.FromArgb(230, 85, 85), new EventHandler((s, e) => OpenChildForm(new frmClasse()))));
                quickAccess.Add(Tuple.Create("\uE7BC", "Matieres", Color.FromArgb(245, 185, 60), new EventHandler((s, e) => OpenChildForm(new frmMatiere()))));
                quickAccess.Add(Tuple.Create("\uE77B", "Professeurs", Color.FromArgb(30, 190, 155), new EventHandler((s, e) => OpenChildForm(new frmProfesseur()))));
                quickAccess.Add(Tuple.Create("\uEC06", "Departements", Color.FromArgb(35, 35, 45), new EventHandler((s, e) => OpenChildForm(new frmDepartement()))));
                quickAccess.Add(Tuple.Create("\uEA18", "Resp. Classe", Color.FromArgb(230, 100, 150), new EventHandler((s, e) => OpenChildForm(new frmResponsableClasse()))));
                quickAccess.Add(Tuple.Create("\uE787", "Seances", Color.FromArgb(30, 190, 155), new EventHandler((s, e) => OpenChildForm(new frmSeance()))));
                quickAccess.Add(Tuple.Create("\uF0E3", "Devoirs", Color.FromArgb(245, 185, 60), new EventHandler((s, e) => OpenChildForm(new frmDevoir()))));
                quickAccess.Add(Tuple.Create("\uE823", "Emploi", Color.FromArgb(230, 85, 85), new EventHandler((s, e) => OpenChildForm(new frmEmploiDuTemps()))));
                quickAccess.Add(Tuple.Create("\uE735", "Affect. Mat.", Color.FromArgb(30, 190, 155), new EventHandler((s, e) => OpenChildForm(new frmProfesseurMatiere()))));
            }
            else if (Profil == "Professeur")
            {
                quickAccess.Add(Tuple.Create("\uE787", "Mes Seances", Color.FromArgb(30, 190, 155), new EventHandler((s, e) => OpenChildForm(new frmSeance()))));
                quickAccess.Add(Tuple.Create("\uF0E3", "Mes Devoirs", Color.FromArgb(245, 185, 60), new EventHandler((s, e) => OpenChildForm(new frmDevoir()))));
                quickAccess.Add(Tuple.Create("\uE823", "Emploi", Color.FromArgb(230, 85, 85), new EventHandler((s, e) => OpenChildForm(new frmEmploiDuTemps()))));
            }
            else
            {
                quickAccess.Add(Tuple.Create("\uE787", "Seances", Color.FromArgb(26, 188, 156), new EventHandler((s, e) => OpenChildForm(new frmSeance()))));
                quickAccess.Add(Tuple.Create("\uF0E3", "Devoirs", Color.FromArgb(241, 196, 15), new EventHandler((s, e) => OpenChildForm(new frmDevoir()))));
            }

            // Quick Access widget container
            Panel qaWidget = CreateWidget(availableWidth, 60 + (int)Math.Ceiling((double)quickAccess.Count / 4) * 80);
            qaWidget.Location = new Point(margin, afterCardsY);
            Label lblQA = CreateWidgetTitle("Acces Rapide");
            qaWidget.Controls.Add(lblQA);

            int qaBtnW = 150, qaBtnH = 60, qaBtnSpacing = 15;
            int qaPerRow = Math.Max(1, (availableWidth - 40 + qaBtnSpacing) / (qaBtnW + qaBtnSpacing));
            for (int i = 0; i < quickAccess.Count; i++)
            {
                int qRow = i / qaPerRow;
                int qCol = i % qaPerRow;
                Button qaBtn = new Button();
                qaBtn.Text = "";
                qaBtn.Size = new Size(qaBtnW, qaBtnH);
                qaBtn.Location = new Point(20 + qCol * (qaBtnW + qaBtnSpacing), 50 + qRow * (qaBtnH + qaBtnSpacing));
                qaBtn.BackColor = quickAccess[i].Item3;
                qaBtn.ForeColor = Color.White;
                qaBtn.FlatStyle = FlatStyle.Flat;
                qaBtn.FlatAppearance.BorderSize = 0;
                qaBtn.Cursor = Cursors.Hand;
                qaBtn.Click += quickAccess[i].Item4;

                string qIc = quickAccess[i].Item1;
                string qTx = quickAccess[i].Item2;

                // Rounded effect + MDL2 icon rendering
                qaBtn.Paint += (s, pe) =>
                {
                    var b = (Button)s;
                    using (var path = new GraphicsPath())
                    {
                        int r = 8;
                        path.AddArc(0, 0, r, r, 180, 90);
                        path.AddArc(b.Width - r, 0, r, r, 270, 90);
                        path.AddArc(b.Width - r, b.Height - r, r, r, 0, 90);
                        path.AddArc(0, b.Height - r, r, r, 90, 90);
                        path.CloseFigure();
                        b.Region = new Region(path);
                    }
                    pe.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    using (var iconFont = new Font("Segoe MDL2 Assets", 16F))
                    using (var textFont = new Font("Segoe UI", 9F, FontStyle.Bold))
                    {
                        var icSz = TextRenderer.MeasureText(qIc, iconFont);
                        TextRenderer.DrawText(pe.Graphics, qIc, iconFont, new Point((b.Width - icSz.Width) / 2, 5), Color.White);
                        var txSz = TextRenderer.MeasureText(qTx, textFont);
                        TextRenderer.DrawText(pe.Graphics, qTx, textFont, new Point((b.Width - txSz.Width) / 2, b.Height - txSz.Height - 5), Color.White);
                    }
                };
                qaWidget.Controls.Add(qaBtn);
            }
            panelDashboard.Controls.Add(qaWidget);
        }

        // ===== WIDGET HELPERS =====
        private Panel CreateWidget(int width, int height)
        {
            Panel widget = new Panel();
            widget.Size = new Size(width, height);
            widget.BackColor = Color.White;
            widget.Padding = new Padding(0);

            // Shadow effect using border
            widget.Paint += (s, e) =>
            {
                var p = (Panel)s;
                using (var pen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
                }
            };
            return widget;
        }

        private Label CreateWidgetTitle(string text)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(35, 35, 45);
            lbl.AutoSize = true;
            lbl.Location = new Point(15, 12);
            return lbl;
        }

        private DataGridView CreateWidgetGrid()
        {
            DataGridView dg = new DataGridView();
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.BackgroundColor = Color.White;
            dg.BorderStyle = BorderStyle.None;
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dg.EnableHeadersVisualStyles = false;
            dg.RowHeadersVisible = false;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg.GridColor = Color.FromArgb(230, 235, 240);
            dg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 230, 230);
            dg.DefaultCellStyle.SelectionForeColor = Color.Black;
            return dg;
        }

        private Panel CreateStatWidget(string title, string value, string icon, Color bgColor, Color darkColor, int width, int height)
        {
            Panel card = CreateWidget(width, height);

            // Accent top bar
            Panel accentBar = new Panel();
            accentBar.Size = new Size(width, 4);
            accentBar.Location = new Point(0, 0);
            accentBar.BackColor = bgColor;
            card.Controls.Add(accentBar);

            // Icon circle
            Label lblIcon = new Label();
            lblIcon.Text = icon;
            lblIcon.Font = new Font("Segoe MDL2 Assets", 22F);
            lblIcon.ForeColor = bgColor;
            lblIcon.AutoSize = false;
            lblIcon.Size = new Size(50, 50);
            lblIcon.Location = new Point(15, 25);
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            card.Controls.Add(lblIcon);

            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(35, 35, 45);
            lblValue.AutoSize = false;
            lblValue.Size = new Size(width - 80, 50);
            lblValue.Location = new Point(70, 18);
            lblValue.TextAlign = ContentAlignment.MiddleLeft;
            card.Controls.Add(lblValue);

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblTitle.ForeColor = Color.FromArgb(120, 130, 150);
            lblTitle.AutoSize = false;
            lblTitle.Size = new Size(width - 30, 25);
            lblTitle.Location = new Point(70, height - 38);
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            card.Controls.Add(lblTitle);

            return card;
        }

        private string GetProfilDisplay(string p)
        {
            if (p == "Administrateur") return "Administrateur";
            if (p == "ChefDepartement") return "Chef de Departement";
            if (p == "Professeur") return "Professeur";
            if (p == "RespClasse") return "Responsable de Classe";
            return "Utilisateur";
        }

        // ===== LOAD =====
        private void frmMDI_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);

            // User info in top bar
            lblUserInfo.Text = (!string.IsNullOrEmpty(UtilisateurNom) ? UtilisateurNom : "Utilisateur") + "  |  " + GetProfilDisplay(Profil);

            BuildSidebar();

            lblDate.Text = DateTime.Now.ToString("dddd dd MMMM yyyy - HH:mm");
            lblStatus.Text = "Connecte : " + GetProfilDisplay(Profil) + (string.IsNullOrEmpty(UtilisateurNom) ? "" : " - " + UtilisateurNom);

            ShowDashboard();
        }
    }
}
