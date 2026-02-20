using AppGestionCahierTexte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Utils
{
    public class LoadData
    {
        BDCahierDeTexteContext db = new BDCahierDeTexteContext();

        public List<ListItem> FillClasse()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.classes.ToList();
            laListe.Add(new ListItem { Value = null, Text = "Selectionner" });
            foreach (var t in liste)
            {
                laListe.Add(new ListItem
                {
                    Value = t.IdClasse.ToString(),
                    Text = t.DesignationClasse
                });
            }
            return laListe;
        }

        public List<ListItem> FillMatiere()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.matieres.ToList();
            laListe.Add(new ListItem { Value = null, Text = "Selectionner" });
            foreach (var t in liste)
            {
                laListe.Add(new ListItem
                {
                    Value = t.IdMatiere.ToString(),
                    Text = t.DesignationMatiere
                });
            }
            return laListe;
        }

        public List<ListItem> FillProfesseur()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.profsseurs.ToList();
            laListe.Add(new ListItem { Value = null, Text = "Selectionner" });
            foreach (var t in liste)
            {
                laListe.Add(new ListItem
                {
                    Value = t.IdU.ToString(),
                    Text = t.NomU + " " + t.PrenomU
                });
            }
            return laListe;
        }

        public List<ListItem> FillDepartement()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.departements.ToList();
            laListe.Add(new ListItem { Value = null, Text = "Selectionner" });
            foreach (var t in liste)
            {
                laListe.Add(new ListItem
                {
                    Value = t.idDepartement.ToString(),
                    Text = t.DesignationDepartement
                });
            }
            return laListe;
        }
    }
}
