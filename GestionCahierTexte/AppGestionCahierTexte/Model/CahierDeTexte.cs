using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class CahierDeTexte
    {
        [Key]
        public int IdCahier { get; set; }

        [MaxLength(100), Required]
        public string Titre { get; set; }

        [Required]
        public DateTime DateCreation { get; set; }

        [MaxLength(20), Required]
        public string AnneeScolaire { get; set; }

        public int IdClasse { get; set; }

        [ForeignKey("IdClasse")]
        public virtual Classe Classe { get; set; }
    }
}
