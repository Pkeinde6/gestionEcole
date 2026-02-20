using AppGestionCahierTexte.Model;
using AppGestionCahierTexte.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCahierTexte.Views.Parametre
{
    public partial class frmProfesseur : Form
    {
        public frmProfesseur()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db = new BDCahierDeTexteContext();

        private void Effacer()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtSpecialite.Text = string.Empty;

            dgProfesseur.DataSource = db.profsseurs.Select(p => new
            {
                p.IdU,
                p.NomU,
                p.PrenomU,
                p.CodeU,
                p.EmailU,
                p.PhoneU,
                p.Specialite
            }).ToList();

            txtNom.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(txtTelephone.Text) ||
                string.IsNullOrWhiteSpace(txtSpecialite.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            Professeur p = new Professeur();
            p.NomU = txtNom.Text;
            p.PrenomU = txtPrenom.Text;
            p.CodeU = txtCode.Text;
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                string emailBase = (txtNom.Text.Trim().ToLower() + "." + txtPrenom.Text.Trim().ToLower()).Replace(" ", "");
                p.EmailU = emailBase + "@classlog.com";
            }
            else
            {
                p.EmailU = txtEmail.Text;
            }
            p.AdresseU = txtAdresse.Text;
            p.PhoneU = txtTelephone.Text;
            p.Specialite = txtSpecialite.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                p.MotDePasse = Crypto.GetMd5Hash(md5Hash, "P@sser123");
            }
            db.profsseurs.Add(p);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;
            int? id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            var p = db.profsseurs.Find(id);
            if (p == null) return;
            txtNom.Text = p.NomU;
            txtPrenom.Text = p.PrenomU;
            txtCode.Text = p.CodeU;
            txtEmail.Text = p.EmailU;
            txtAdresse.Text = p.AdresseU;
            txtTelephone.Text = p.PhoneU;
            txtSpecialite.Text = p.Specialite;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;
            int? id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            var p = db.profsseurs.Find(id);
            if (p == null) return;
            p.NomU = txtNom.Text;
            p.PrenomU = txtPrenom.Text;
            p.CodeU = txtCode.Text;
            p.EmailU = txtEmail.Text;
            p.AdresseU = txtAdresse.Text;
            p.PhoneU = txtTelephone.Text;
            p.Specialite = txtSpecialite.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;
            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int? id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            var p = db.profsseurs.Find(id);
            if (p == null) return;
            db.profsseurs.Remove(p);
            db.SaveChanges();
            Effacer();
        }

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.profsseurs.Select(p => new
            {
                p.IdU,
                p.NomU,
                p.PrenomU,
                p.CodeU,
                p.EmailU,
                p.PhoneU,
                p.Specialite
            }).ToList();

            if (!string.IsNullOrEmpty(txtRNom.Text))
            {
                liste = liste.Where(a => a.NomU.ToUpper().Contains(txtRNom.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtRSpecialite.Text))
            {
                liste = liste.Where(a => a.Specialite.ToUpper().Contains(txtRSpecialite.Text.ToUpper())).ToList();
            }
            dgProfesseur.DataSource = liste;
        }
    }
}
