using AppGestionCahierTexte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Utils
{
    public  class LoadData
    {
        BDCahierDeTexteContext db=new BDCahierDeTexteContext();
        public List<ListItem> FillClasse()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.classes.ToList();
            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.CodeClasse.ToString(),
                    Text = t.DesignationClasse.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }
    }
}
