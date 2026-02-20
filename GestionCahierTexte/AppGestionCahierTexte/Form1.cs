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
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                using (BDCahierDeTexteContext db = new BDCahierDeTexteContext())
                {
                    var leUser = db.utilisateurs.Where(a => a.EmailU == txtIdentifiant.Text).FirstOrDefault();
                    if (leUser != null)
                    {
                        string hash = leUser.MotDePasse;
                        using (MD5 md5Hash = MD5.Create())
                        {
                            if (Crypto.VerifyMd5Hash(md5Hash, txtMotdePasse.Text, hash))
                            {
                                frmMDI f = new frmMDI();
                               if (leUser is Administrateur)
                               {
                                   f.Profil = "Administrateur";
                               }
                               else if (leUser is ChefDepartement)
                               {
                                   f.Profil = "ChefDepartement";
                               }
                               else if (leUser is Professeur)
                               {
                                   f.Profil = "Professeur";
                               }
                               else if (leUser is ResponsableClasse)
                                {
                                    f.Profil = "RespClasse";
                                }
                                f.UtilisateurId = leUser.IdU;
                                f.UtilisateurNom = leUser.NomU + " " + leUser.PrenomU;
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
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
