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
    public partial class frmProfesseurMatiere : Form
    {
        public frmProfesseurMatiere()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db;

        private void Effacer()
        {
            LoadData loadData = new LoadData();

            cbProfesseur.DataSource = loadData.FillProfesseur();
            cbProfesseur.DisplayMember = "Text";
            cbProfesseur.ValueMember = "Value";

            cbMatiere.DataSource = loadData.FillMatiere();
            cbMatiere.DisplayMember = "Text";
            cbMatiere.ValueMember = "Value";

            dgAffectation.DataSource = db.professeurMatieres.Select(pm => new
            {
                pm.IdProfesseur,
                Professeur = pm.Professeur.NomU + " " + pm.Professeur.PrenomU,
                pm.IdMatiere,
                Matiere = pm.Matiere.DesignationMatiere
            }).ToList();

            cbProfesseur.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (cbProfesseur.SelectedValue == null || cbMatiere.SelectedValue == null)
            {
                MessageBox.Show("Veuillez selectionner un Professeur et une Matiere.");
                return;
            }

            int idProf, idMat;
            if (!int.TryParse(cbProfesseur.SelectedValue.ToString(), out idProf) ||
                !int.TryParse(cbMatiere.SelectedValue.ToString(), out idMat))
            {
                MessageBox.Show("Veuillez selectionner des valeurs valides.");
                return;
            }

            // Vérifier si l'affectation existe déjà
            var existe = db.professeurMatieres.Find(idProf, idMat);
            if (existe != null)
            {
                MessageBox.Show("Cette affectation existe deja.");
                return;
            }

            ProfesseurMatiere pm = new ProfesseurMatiere();
            pm.IdProfesseur = idProf;
            pm.IdMatiere = idMat;
            db.professeurMatieres.Add(pm);
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgAffectation.CurrentRow == null) return;
            if (MessageBox.Show("Voulez-vous vraiment supprimer cette affectation ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            int idProf = int.Parse(dgAffectation.CurrentRow.Cells[0].Value.ToString());
            int idMat = int.Parse(dgAffectation.CurrentRow.Cells[2].Value.ToString());
            var pm = db.professeurMatieres.Find(idProf, idMat);
            if (pm == null) return;
            db.professeurMatieres.Remove(pm);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgAffectation.CurrentRow == null) return;
            int idProf = int.Parse(dgAffectation.CurrentRow.Cells[0].Value.ToString());
            int idMat = int.Parse(dgAffectation.CurrentRow.Cells[2].Value.ToString());
            cbProfesseur.SelectedValue = idProf.ToString();
            cbMatiere.SelectedValue = idMat.ToString();
        }

        private void frmProfesseurMatiere_Load(object sender, EventArgs e)
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
            var liste = db.professeurMatieres.Select(pm => new
            {
                pm.IdProfesseur,
                Professeur = pm.Professeur.NomU + " " + pm.Professeur.PrenomU,
                pm.IdMatiere,
                Matiere = pm.Matiere.DesignationMatiere
            }).ToList();

            if (!string.IsNullOrEmpty(txtRProfesseur.Text))
            {
                liste = liste.Where(a => a.Professeur.ToUpper().Contains(txtRProfesseur.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtRMatiere.Text))
            {
                liste = liste.Where(a => a.Matiere.ToUpper().Contains(txtRMatiere.Text.ToUpper())).ToList();
            }
            dgAffectation.DataSource = liste;
        }

        private void cbProfesseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProfesseur.SelectedValue == null) return;
            int idProf;
            if (!int.TryParse(cbProfesseur.SelectedValue.ToString(), out idProf)) return;

            var matieres = db.professeurMatieres
                .Where(pm => pm.IdProfesseur == idProf)
                .Select(pm => new
                {
                    pm.IdProfesseur,
                    Professeur = pm.Professeur.NomU + " " + pm.Professeur.PrenomU,
                    pm.IdMatiere,
                    Matiere = pm.Matiere.DesignationMatiere
                }).ToList();

            if (matieres.Count > 0)
            {
                dgAffectation.DataSource = matieres;
            }
        }
    }
}
