using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class EmploiDuTemps
    {
        [Key]
        public int IdEmploi { get; set; }

        [MaxLength(20), Required]
        public string JourSemaine { get; set; }

        [MaxLength(20), Required]
        public string HeureDebut { get; set; }

        [MaxLength(20), Required]
        public string HeureFin { get; set; }

        [MaxLength(100)]
        public string Salle { get; set; }

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
