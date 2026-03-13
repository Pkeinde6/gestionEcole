using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionCahierTexte.Model;
using AppGestionCahierTexte.Utils;

namespace AppGestionCahierTexte.Views.Parametre
{
    public partial class frmSeance : Form
    {
        public frmSeance()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db;

        private void Effacer()
        {
            LoadData loadData = new LoadData();

            txtContenu.Text = string.Empty;
            txtObservation.Text = string.Empty;
            txtHeureDebut.Text = string.Empty;
            txtHeureFin.Text = string.Empty;
            dtpDate.Value = DateTime.Now;

            cbProfesseur.DataSource = loadData.FillProfesseur();
            cbProfesseur.DisplayMember = "Text";
            cbProfesseur.ValueMember = "Value";

            cbMatiere.DataSource = loadData.FillMatiere();
            cbMatiere.DisplayMember = "Text";
            cbMatiere.ValueMember = "Value";

            cbClasse.DataSource = loadData.FillClasse();
            cbClasse.DisplayMember = "Text";
            cbClasse.ValueMember = "Value";

            // Si le user est un Professeur, auto-sélectionner et verrouiller
            var mdi = this.MdiParent as frmMDI;
            if (mdi != null && mdi.Profil == "Professeur" && mdi.UtilisateurId > 0)
            {
                cbProfesseur.SelectedValue = mdi.UtilisateurId.ToString();
                cbProfesseur.Enabled = false;

                dgSeance.DataSource = db.seances
                    .Where(s => s.IdProfesseur == mdi.UtilisateurId)
                    .Select(s => new
                    {
                        s.IdSeance,
                        s.DateSeance,
                        s.HeureDebut,
                        s.HeureFin,
                        s.Contenu,
                        Professeur = s.Professeur.NomU + " " + s.Professeur.PrenomU,
                        Matiere = s.Matiere.DesignationMatiere,
                        Classe = s.Classe.DesignationClasse
                    }).ToList();
            }
            else
            {
                dgSeance.DataSource = db.seances.Select(s => new
                {
                    s.IdSeance,
                    s.DateSeance,
                    s.HeureDebut,
                    s.HeureFin,
                    s.Contenu,
                    Professeur = s.Professeur.NomU + " " + s.Professeur.PrenomU,
                    Matiere = s.Matiere.DesignationMatiere,
                    Classe = s.Classe.DesignationClasse
                }).ToList();
            }

            txtContenu.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContenu.Text) || string.IsNullOrWhiteSpace(txtHeureDebut.Text) ||
                string.IsNullOrWhiteSpace(txtHeureFin.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }
            if (cbProfesseur.SelectedValue == null || cbMatiere.SelectedValue == null || cbClasse.SelectedValue == null)
            {
                MessageBox.Show("Veuillez selectionner Professeur, Matiere et Classe.");
                return;
            }

            int idProf, idMat, idCl;
            if (!int.TryParse(cbProfesseur.SelectedValue.ToString(), out idProf) ||
                !int.TryParse(cbMatiere.SelectedValue.ToString(), out idMat) ||
                !int.TryParse(cbClasse.SelectedValue.ToString(), out idCl))
            {
                MessageBox.Show("Veuillez selectionner des valeurs valides.");
                return;
            }

            Seance s = new Seance();
            s.DateSeance = dtpDate.Value;
            s.HeureDebut = txtHeureDebut.Text;
            s.HeureFin = txtHeureFin.Text;
            s.Contenu = txtContenu.Text;
            s.Observation = txtObservation.Text;
            s.IdProfesseur = idProf;
            s.IdMatiere = idMat;
            s.IdClasse = idCl;
            db.seances.Add(s);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgSeance.CurrentRow == null) return;
            int id = int.Parse(dgSeance.CurrentRow.Cells[0].Value.ToString());
            var s = db.seances.Find(id);
            if (s == null) return;
            dtpDate.Value = s.DateSeance;
            txtHeureDebut.Text = s.HeureDebut;
            txtHeureFin.Text = s.HeureFin;
            txtContenu.Text = s.Contenu;
            txtObservation.Text = s.Observation;
            cbProfesseur.SelectedValue = s.IdProfesseur.ToString();
            cbMatiere.SelectedValue = s.IdMatiere.ToString();
            cbClasse.SelectedValue = s.IdClasse.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSeance.CurrentRow == null) return;
            int id = int.Parse(dgSeance.CurrentRow.Cells[0].Value.ToString());
            var s = db.seances.Find(id);
            if (s == null) return;

            int idProf, idMat, idCl;
            if (!int.TryParse(cbProfesseur.SelectedValue?.ToString(), out idProf) ||
                !int.TryParse(cbMatiere.SelectedValue?.ToString(), out idMat) ||
                !int.TryParse(cbClasse.SelectedValue?.ToString(), out idCl))
            {
                MessageBox.Show("Veuillez selectionner des valeurs valides.");
                return;
            }

            s.DateSeance = dtpDate.Value;
            s.HeureDebut = txtHeureDebut.Text;
            s.HeureFin = txtHeureFin.Text;
            s.Contenu = txtContenu.Text;
            s.Observation = txtObservation.Text;
            s.IdProfesseur = idProf;
            s.IdMatiere = idMat;
            s.IdClasse = idCl;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSeance.CurrentRow == null) return;
            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int id = int.Parse(dgSeance.CurrentRow.Cells[0].Value.ToString());
            var s = db.seances.Find(id);
            if (s == null) return;
            db.seances.Remove(s);
            db.SaveChanges();
            Effacer();
        }

        private void frmSeance_Load(object sender, EventArgs e)
        {
            try
            {
                db = new BDCahierDeTexteContext();
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var query = db.seances.AsQueryable();

            // Filtrer par prof si l'utilisateur est un Professeur
            var mdi = this.MdiParent as frmMDI;
            if (mdi != null && mdi.Profil == "Professeur" && mdi.UtilisateurId > 0)
            {
                query = query.Where(s => s.IdProfesseur == mdi.UtilisateurId);
            }

            if (!string.IsNullOrEmpty(txtRContenu.Text))
            {
                string contenu = txtRContenu.Text.ToUpper();
                query = query.Where(s => s.Contenu.ToUpper().Contains(contenu));
            }

            dgSeance.DataSource = query.Select(s => new
            {
                s.IdSeance,
                s.DateSeance,
                s.HeureDebut,
                s.HeureFin,
                s.Contenu,
                Professeur = s.Professeur.NomU + " " + s.Professeur.PrenomU,
                Matiere = s.Matiere.DesignationMatiere,
                Classe = s.Classe.DesignationClasse
            }).ToList();
        }
    }
}
