using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Seance
    {
        [Key]
        public int IdSeance { get; set; }

        [Required]
        public DateTime DateSeance { get; set; }

        [MaxLength(20), Required]
        public string HeureDebut { get; set; }

        [MaxLength(20), Required]
        public string HeureFin { get; set; }

        [MaxLength(500), Required]
        public string Contenu { get; set; }

        [MaxLength(500)]
        public string Observation { get; set; }

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
