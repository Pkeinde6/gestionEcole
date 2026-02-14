using AppGestionCahierTexte.Views.CahierTexte;
using AppGestionCahierTexte.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCahierTexte
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        public string Profil;
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();

        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmMatiere chForm = new frmMatiere();

            //Set parent form for the child window 
            chForm.MdiParent = this;

            //Display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;

        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmClasse chForm = new frmClasse();

            //Set parent form for the child window 
            chForm.MdiParent = this;

            //Display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;

        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmProfesseur chForm = new frmProfesseur();

            //Set parent form for the child window 
            chForm.MdiParent = this;

            //Display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;

        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
            if(Profil=="RespClasse")
            {
                securiteToolStripMenuItem.Visible=false;
                parametreToolStripMenuItem.Visible=false;
            }
        }

        private void responsableClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmResponsableClasse chForm = new frmResponsableClasse();

            //Set parent form for the child window 
            chForm.MdiParent = this;

            //Display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }
    }
}
