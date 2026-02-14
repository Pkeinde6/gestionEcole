using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Classe
    {
        [Key]
        public int IdClasse { get; set; }
        [Required, MaxLength(4)]
        public string CodeClasse { get; set; }
        [Required, MaxLength(100)]
        public string DesignationClasse { get; set; }
    }
}
