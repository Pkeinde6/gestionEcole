using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Professeur:Utilisateur
    {
        [MaxLength(80), Required]
        public string Specialite { get; set; }
    }
}
