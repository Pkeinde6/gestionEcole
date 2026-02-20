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
    public partial class frmDevoir : Form
    {
        public frmDevoir()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db = new BDCahierDeTexteContext();

        private void Effacer()
        {
            LoadData loadData = new LoadData();

            txtTitre.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtStatut.Text = "En cours";
            dtpDateCreation.Value = DateTime.Now;
            dtpDateLimite.Value = DateTime.Now.AddDays(7);

            cbProfesseur.DataSource = loadData.FillProfesseur();
            cbProfesseur.DisplayMember = "Text";
            cbProfesseur.ValueMember = "Value";

            cbMatiere.DataSource = loadData.FillMatiere();
            cbMatiere.DisplayMember = "Text";
            cbMatiere.ValueMember = "Value";

            cbClasse.DataSource = loadData.FillClasse();
            cbClasse.DisplayMember = "Text";
            cbClasse.ValueMember = "Value";

            dgDevoir.DataSource = db.devoirs.Select(d => new
            {
                d.IdDevoir,
                d.Titre,
                d.DateCreation,
                d.DateLimite,
                d.Statut,
                Professeur = d.Professeur.NomU + " " + d.Professeur.PrenomU,
                Matiere = d.Matiere.DesignationMatiere,
                Classe = d.Classe.DesignationClasse
            }).ToList();

            txtTitre.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitre.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Veuillez remplir le titre et la description.");
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

            Devoir d = new Devoir();
            d.Titre = txtTitre.Text;
            d.Description = txtDescription.Text;
            d.DateCreation = dtpDateCreation.Value;
            d.DateLimite = dtpDateLimite.Value;
            d.Statut = txtStatut.Text;
            d.IdProfesseur = idProf;
            d.IdMatiere = idMat;
            d.IdClasse = idCl;
            db.devoirs.Add(d);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgDevoir.CurrentRow == null) return;
            int id = int.Parse(dgDevoir.CurrentRow.Cells[0].Value.ToString());
            var d = db.devoirs.Find(id);
            if (d == null) return;
            txtTitre.Text = d.Titre;
            txtDescription.Text = d.Description;
            dtpDateCreation.Value = d.DateCreation;
            dtpDateLimite.Value = d.DateLimite;
            txtStatut.Text = d.Statut;
            cbProfesseur.SelectedValue = d.IdProfesseur.ToString();
            cbMatiere.SelectedValue = d.IdMatiere.ToString();
            cbClasse.SelectedValue = d.IdClasse.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgDevoir.CurrentRow == null) return;
            int id = int.Parse(dgDevoir.CurrentRow.Cells[0].Value.ToString());
            var d = db.devoirs.Find(id);
            if (d == null) return;

            int idProf, idMat, idCl;
            if (!int.TryParse(cbProfesseur.SelectedValue?.ToString(), out idProf) ||
                !int.TryParse(cbMatiere.SelectedValue?.ToString(), out idMat) ||
                !int.TryParse(cbClasse.SelectedValue?.ToString(), out idCl))
            {
                MessageBox.Show("Veuillez selectionner des valeurs valides.");
                return;
            }

            d.Titre = txtTitre.Text;
            d.Description = txtDescription.Text;
            d.DateCreation = dtpDateCreation.Value;
            d.DateLimite = dtpDateLimite.Value;
            d.Statut = txtStatut.Text;
            d.IdProfesseur = idProf;
            d.IdMatiere = idMat;
            d.IdClasse = idCl;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgDevoir.CurrentRow == null) return;
            if (MessageBox.Show("Voulez-vous vraiment supprimer ce devoir ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int id = int.Parse(dgDevoir.CurrentRow.Cells[0].Value.ToString());
            var d = db.devoirs.Find(id);
            if (d == null) return;
            db.devoirs.Remove(d);
            db.SaveChanges();
            Effacer();
        }

        private void frmDevoir_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.devoirs.Select(d => new
            {
                d.IdDevoir,
                d.Titre,
                d.DateCreation,
                d.DateLimite,
                d.Statut,
                Professeur = d.Professeur.NomU + " " + d.Professeur.PrenomU,
                Matiere = d.Matiere.DesignationMatiere,
                Classe = d.Classe.DesignationClasse
            }).ToList();

            if (!string.IsNullOrEmpty(txtRTitre.Text))
            {
                liste = liste.Where(a => a.Titre.ToUpper().Contains(txtRTitre.Text.ToUpper())).ToList();
            }
            dgDevoir.DataSource = liste;
        }
    }
}
