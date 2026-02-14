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

namespace AppGestionCahierTexte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            BDCahierDeTexteContext db = new BDCahierDeTexteContext();
            var leUser = db.utilisateurs.Where(a => a.EmailU == txtIdentifiant.Text).FirstOrDefault();
            if (leUser != null)
            {
                string hash = leUser.MotDePasse;
                using (MD5 md5Hash = MD5.Create())
                {
                    if (Crypto.VerifyMd5Hash(md5Hash, txtMotdePasse.Text, hash))
                    {                 
                        frmMDI f = new frmMDI();
                        if (db.responsableClasses.Find(leUser.IdU) != null)
                        {
                            f.Profil = "RespClasse";
                        }
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect");
                    }
                }
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
            }




        }
    }
}
