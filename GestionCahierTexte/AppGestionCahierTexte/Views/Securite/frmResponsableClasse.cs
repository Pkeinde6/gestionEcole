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

namespace AppGestionCahierTexte.Views.CahierTexte
{
    public partial class frmResponsableClasse : Form
    {
        public frmResponsableClasse()
        {
            InitializeComponent();
        }

        BDCahierDeTexteContext db = new BDCahierDeTexteContext();

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
            r.IdClasse = db.classes.Where(a=>a.CodeClasse==cbClasse.SelectedValue.ToString()).FirstOrDefault().IdClasse;
            db.responsableClasses.Add(r);
            db.SaveChanges();
            Effacer();

        }


        private void ResponsableClasse_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgResponsable.CurrentRow.Cells[0].Value.ToString());
            var u = db.responsableClasses.Find(id);
            txtNom.Text=u.NomU;
            txtPrenom.Text=u.PrenomU;
            txtAdresse.Text=u.AdresseU;
            txtCode.Text = u.CodeU;
            txtEmail.Text = u.EmailU;
            txtTelephone.Text = u.PhoneU;
            cbClasse.SelectedValue = db.classes.Find(u.IdClasse).CodeClasse;
        }
    }
}
