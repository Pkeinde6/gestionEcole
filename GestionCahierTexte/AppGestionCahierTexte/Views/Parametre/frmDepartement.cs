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

namespace AppGestionCahierTexte.Views.Parametre
{
    public partial class frmDepartement : Form
    {
        public frmDepartement()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db;

        private void Effacer()
        {
            txtCode.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            dgDepartement.DataSource = db.departements.ToList();
            txtCode.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtDesignation.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            Departement d = new Departement();
            d.CodeDepartement = txtCode.Text;
            d.DesignationDepartement = txtDesignation.Text;
            db.departements.Add(d);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;
            txtCode.Text = dgDepartement.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgDepartement.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;
            int id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            var d = db.departements.Find(id);
            if (d == null) return;
            d.CodeDepartement = txtCode.Text;
            d.DesignationDepartement = txtDesignation.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;
            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            var d = db.departements.Find(id);
            if (d == null) return;
            db.departements.Remove(d);
            db.SaveChanges();
            Effacer();
        }

        private void frmDepartement_Load(object sender, EventArgs e)
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
            var liste = db.departements.ToList();
            if (!string.IsNullOrEmpty(txtRCode.Text))
            {
                liste = liste.Where(a => a.CodeDepartement.ToUpper().Contains(txtRCode.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtRDesignation.Text))
            {
                liste = liste.Where(a => a.DesignationDepartement.ToUpper().Contains(txtRDesignation.Text.ToUpper())).ToList();
            }
            dgDepartement.DataSource = liste;
        }
    }
}
