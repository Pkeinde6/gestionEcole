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
    public partial class frmEmploiDuTemps : Form
    {
        public frmEmploiDuTemps()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db = new BDCahierDeTexteContext();

        private void Effacer()
        {
            LoadData loadData = new LoadData();

            cbJour.SelectedIndex = 0;
            txtHeureDebut.Text = string.Empty;
            txtHeureFin.Text = string.Empty;
            txtSalle.Text = string.Empty;

            cbProfesseur.DataSource = loadData.FillProfesseur();
            cbProfesseur.DisplayMember = "Text";
            cbProfesseur.ValueMember = "Value";

            cbMatiere.DataSource = loadData.FillMatiere();
            cbMatiere.DisplayMember = "Text";
            cbMatiere.ValueMember = "Value";

            cbClasse.DataSource = loadData.FillClasse();
            cbClasse.DisplayMember = "Text";
            cbClasse.ValueMember = "Value";

            dgEmploi.DataSource = db.emploiDuTemps.Select(em => new
            {
                em.IdEmploi,
                em.JourSemaine,
                em.HeureDebut,
                em.HeureFin,
                em.Salle,
                Professeur = em.Professeur.NomU + " " + em.Professeur.PrenomU,
                Matiere = em.Matiere.DesignationMatiere,
                Classe = em.Classe.DesignationClasse
            }).ToList();

            txtHeureDebut.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHeureDebut.Text) || string.IsNullOrWhiteSpace(txtHeureFin.Text))
            {
                MessageBox.Show("Veuillez remplir les heures de debut et fin.");
                return;
            }
            if (cbProfesseur.SelectedValue == null || cbMatiere.SelectedValue == null || cbClasse.SelectedValue == null)
            {
                MessageBox.Show("Veuillez selectionner Professeur, Matiere et Classe.");
                return;
            }
            if (cbJour.SelectedIndex <= 0)
            {
                MessageBox.Show("Veuillez selectionner un jour.");
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

            EmploiDuTemps em = new EmploiDuTemps();
            em.JourSemaine = cbJour.SelectedItem.ToString();
            em.HeureDebut = txtHeureDebut.Text;
            em.HeureFin = txtHeureFin.Text;
            em.Salle = txtSalle.Text;
            em.IdProfesseur = idProf;
            em.IdMatiere = idMat;
            em.IdClasse = idCl;
            db.emploiDuTemps.Add(em);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgEmploi.CurrentRow == null) return;
            int id = int.Parse(dgEmploi.CurrentRow.Cells[0].Value.ToString());
            var em = db.emploiDuTemps.Find(id);
            if (em == null) return;
            cbJour.SelectedItem = em.JourSemaine;
            txtHeureDebut.Text = em.HeureDebut;
            txtHeureFin.Text = em.HeureFin;
            txtSalle.Text = em.Salle;
            cbProfesseur.SelectedValue = em.IdProfesseur.ToString();
            cbMatiere.SelectedValue = em.IdMatiere.ToString();
            cbClasse.SelectedValue = em.IdClasse.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgEmploi.CurrentRow == null) return;
            int id = int.Parse(dgEmploi.CurrentRow.Cells[0].Value.ToString());
            var em = db.emploiDuTemps.Find(id);
            if (em == null) return;

            int idProf, idMat, idCl;
            if (!int.TryParse(cbProfesseur.SelectedValue?.ToString(), out idProf) ||
                !int.TryParse(cbMatiere.SelectedValue?.ToString(), out idMat) ||
                !int.TryParse(cbClasse.SelectedValue?.ToString(), out idCl))
            {
                MessageBox.Show("Veuillez selectionner des valeurs valides.");
                return;
            }

            em.JourSemaine = cbJour.SelectedItem.ToString();
            em.HeureDebut = txtHeureDebut.Text;
            em.HeureFin = txtHeureFin.Text;
            em.Salle = txtSalle.Text;
            em.IdProfesseur = idProf;
            em.IdMatiere = idMat;
            em.IdClasse = idCl;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgEmploi.CurrentRow == null) return;
            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int id = int.Parse(dgEmploi.CurrentRow.Cells[0].Value.ToString());
            var em = db.emploiDuTemps.Find(id);
            if (em == null) return;
            db.emploiDuTemps.Remove(em);
            db.SaveChanges();
            Effacer();
        }

        private void frmEmploiDuTemps_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.emploiDuTemps.Select(em => new
            {
                em.IdEmploi,
                em.JourSemaine,
                em.HeureDebut,
                em.HeureFin,
                em.Salle,
                Professeur = em.Professeur.NomU + " " + em.Professeur.PrenomU,
                Matiere = em.Matiere.DesignationMatiere,
                Classe = em.Classe.DesignationClasse
            }).ToList();

            if (!string.IsNullOrEmpty(txtRJour.Text))
            {
                liste = liste.Where(a => a.JourSemaine.ToUpper().Contains(txtRJour.Text.ToUpper())).ToList();
            }
            dgEmploi.DataSource = liste;
        }
    }
}
