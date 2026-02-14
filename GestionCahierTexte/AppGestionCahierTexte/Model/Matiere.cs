using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Matiere
    {
        [Key]
        public int IdMatiere { get; set; }
        [Required, MaxLength(10)]
        public string CodeMatiere { get; set; }
        [Required, MaxLength(100)]
        public string DesignationMatiere { get; set; }
    }
}
