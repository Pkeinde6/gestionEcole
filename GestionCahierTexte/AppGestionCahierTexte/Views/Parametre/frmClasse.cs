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
    public partial class frmClasse : Form
    {
        public frmClasse()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db = new BDCahierDeTexteContext();

        private void Effacer()
        {
            txtCode.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            dgClasse.DataSource = db.classes.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Classe c = new Classe();
            c.CodeClasse = txtCode.Text;
            c.DesignationClasse = txtDesignation.Text;
            db.classes.Add(c);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgClasse.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgClasse.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgClasse.CurrentRow.Cells[1].Value.ToString());
            var c = db.classes.Find(id);
            c.DesignationClasse = txtDesignation.Text;
            c.CodeClasse = txtCode.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgClasse.CurrentRow.Cells[1].Value.ToString());
            var c = db.classes.Find(id);
            db.classes.Remove(c);
            db.SaveChanges();
            Effacer();
        }

        private void frmClasse_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.classes.ToList();
            if (!string.IsNullOrEmpty(txtRCode.Text))
            {
                liste = liste.Where(a=>a.CodeClasse.ToUpper().Contains(txtRCode.Text.ToUpper())).ToList();

            }
            if (!string.IsNullOrEmpty(txtRDesignation.Text))
            {
                liste = liste.Where(a => a.DesignationClasse.ToUpper().Contains(txtRDesignation.Text.ToUpper())).ToList();

            }
            dgClasse.DataSource = liste;
        }
    }
}
