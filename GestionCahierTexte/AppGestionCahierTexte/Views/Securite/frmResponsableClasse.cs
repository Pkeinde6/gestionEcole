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

namespace AppGestionCahierTexte.Views.Securite
{
    public partial class frmResponsableClasse : Form
    {
        public frmResponsableClasse()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db;

        //int? id = null;

       

        private void Effacer()
        {
            LoadData loadData = new LoadData();
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtTelephone.Text = string.Empty;

            cbClasse.DataSource = loadData.FillClasse();
            cbClasse.DisplayMember = "Text";
            cbClasse.ValueMember = "Value";

            dgResponsable.DataSource = db.responsableClasses.Select(r=> new
            {
                r.IdU,
                r.NomU,
                r.PrenomU,
                r.CodeU,
                r.EmailU,
                Classe = r.Classe.DesignationClasse
            }).ToList();

            //id = null;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            if (cbClasse.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe.");
                return;
            }
            var classe = db.classes.Where(a => a.CodeClasse == cbClasse.SelectedValue.ToString()).FirstOrDefault();
            if (classe == null)
            {
                MessageBox.Show("Classe introuvable.");
                return;
            }
            ResponsableClasse r = new ResponsableClasse();
            r.NomU= txtNom.Text;
            r.CodeU= txtCode.Text;
            r.EmailU= txtEmail.Text;
            r.AdresseU= txtAdresse.Text;
            r.PhoneU= txtTelephone.Text;
            using (MD5 md5Hash = MD5.Create())
            {                
                r.MotDePasse = Crypto.GetMd5Hash(md5Hash, "P@sser123");                
            }
            r.PrenomU= txtPrenom.Text;
            r.IdClasse = classe.IdClasse;
            db.responsableClasses.Add(r);
            db.SaveChanges();
            Effacer();

        }


        private void ResponsableClasse_Load(object sender, EventArgs e)
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

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgResponsable.CurrentRow == null) return;
            int? id = int.Parse(dgResponsable.CurrentRow.Cells[0].Value.ToString());
            var u = db.responsableClasses.Find(id);
            if (u == null) return;
            txtNom.Text=u.NomU;
            txtPrenom.Text=u.PrenomU;
            txtAdresse.Text=u.AdresseU;
            txtCode.Text = u.CodeU;
            txtEmail.Text = u.EmailU;
            txtTelephone.Text = u.PhoneU;
            var classeFound = db.classes.Find(u.IdClasse);
            if (classeFound != null)
                cbClasse.SelectedValue = classeFound.CodeClasse;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgResponsable.CurrentRow == null) return;
            if (cbClasse.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe.");
                return;
            }
            var classe = db.classes.Where(a => a.CodeClasse == cbClasse.SelectedValue.ToString()).FirstOrDefault();
            if (classe == null)
            {
                MessageBox.Show("Classe introuvable.");
                return;
            }
            int? id = int.Parse(dgResponsable.CurrentRow.Cells[0].Value.ToString());
            var r = db.responsableClasses.Find(id);
            if (r == null) return;
            r.NomU = txtNom.Text;
            r.PrenomU = txtPrenom.Text;
            r.CodeU = txtCode.Text;
            r.EmailU = txtEmail.Text;
            r.AdresseU = txtAdresse.Text;
            r.PhoneU = txtTelephone.Text;
            r.IdClasse = classe.IdClasse;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgResponsable.CurrentRow == null) return;
            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int? id = int.Parse(dgResponsable.CurrentRow.Cells[0].Value.ToString());
            var r = db.responsableClasses.Find(id);
            if (r == null) return;
            db.responsableClasses.Remove(r);
            db.SaveChanges();
            Effacer();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string nom = txtRNom.Text.Trim().ToLower();
            var query = db.responsableClasses.AsQueryable();
            if (!string.IsNullOrEmpty(nom))
                query = query.Where(r => r.NomU.ToLower().Contains(nom) || r.PrenomU.ToLower().Contains(nom));
            dgResponsable.DataSource = query.Select(r => new
            {
                r.IdU,
                r.NomU,
                r.PrenomU,
                r.CodeU,
                r.EmailU,
                Classe = r.Classe.DesignationClasse
            }).ToList();
        }
    }
}
