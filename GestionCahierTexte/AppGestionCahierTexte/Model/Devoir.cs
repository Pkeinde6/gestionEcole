using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Devoir
    {
        [Key]
        public int IdDevoir { get; set; }

        [MaxLength(150), Required]
        public string Titre { get; set; }

        [MaxLength(1000), Required]
        public string Description { get; set; }

        [Required]
        public DateTime DateCreation { get; set; }

        [Required]
        public DateTime DateLimite { get; set; }

        [MaxLength(50)]
        public string Statut { get; set; }

        public int IdProfesseur { get; set; }

        [ForeignKey("IdProfesseur")]
        public virtual Professeur Professeur { get; set; }

        public int IdMatiere { get; set; }

        [ForeignKey("IdMatiere")]
        public virtual Matiere Matiere { get; set; }

        public int IdClasse { get; set; }

        [ForeignKey("IdClasse")]
        public virtual Classe Classe { get; set; }
    }
}
