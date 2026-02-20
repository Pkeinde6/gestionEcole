using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class ProfesseurMatiere
    {
        [Key]
        [Column(Order = 2)]
        public int IdMatiere { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IdProfesseur { get; set; }

        [ForeignKey("IdProfesseur")]
        public virtual Professeur Professeur { get; set; }

        [ForeignKey("IdMatiere")]
        public virtual Matiere Matiere { get; set; }
    }
}
