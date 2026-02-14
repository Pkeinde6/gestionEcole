using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Syllabus
    {
        [Key]
        public int IdSyllabus {  get; set; }

        [MaxLength(80), Required]
        public string Objectif {  get; set; }

        [MaxLength(10), Required]
        public string ModeEvaluation { get; set; }

        [MaxLength(50), Required]
        public string Duree { get; set; }
    }
}
