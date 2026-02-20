using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Administrateur : Utilisateur
    {
        [MaxLength(100)]
        public string Fonction { get; set; }
    }
}
