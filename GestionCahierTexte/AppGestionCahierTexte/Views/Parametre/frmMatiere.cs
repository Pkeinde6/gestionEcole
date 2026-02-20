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
    public partial class frmMatiere : Form
    {
        public frmMatiere()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db= new BDCahierDeTexteContext();

        private void Effacer()
        {
            txtCode.Text= string.Empty;
            txtDesignation.Text= string.Empty;
            dgMatiere.DataSource= db.matieres.ToList();
            txtCode.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtDesignation.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            Matiere m = new Matiere();
            m.CodeMatiere=txtCode.Text;
            m.DesignationMatiere=txtDesignation.Text;
            db.matieres.Add(m);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgMatiere.CurrentRow == null) return;
            txtCode.Text=dgMatiere.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgMatiere.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgMatiere.CurrentRow == null) return;
            int? id = int.Parse(dgMatiere.CurrentRow.Cells[0].Value.ToString());
            var m = db.matieres.Find(id);
            if (m == null) return;
            m.DesignationMatiere=txtDesignation.Text;
            m.CodeMatiere = txtCode.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgMatiere.CurrentRow == null) return;
            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int? id = int.Parse(dgMatiere.CurrentRow.Cells[0].Value.ToString());
            var m = db.matieres.Find(id);
            if (m == null) return;
            db.matieres.Remove(m);
            db.SaveChanges();
            Effacer();
        }

        private void frmMatiere_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.matieres.ToList();
            if(!string.IsNullOrEmpty(txtRCode.Text))
            {
               liste=liste.Where(a=>a.CodeMatiere.ToUpper().Contains(txtRCode.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtRDesignation.Text))
            {
                liste = liste.Where(a => a.DesignationMatiere.ToUpper().Contains(txtRDesignation.Text.ToUpper())).ToList();
            }
            dgMatiere.DataSource = liste;
        }
    }
}
