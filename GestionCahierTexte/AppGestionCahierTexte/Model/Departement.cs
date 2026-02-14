using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Departement
    {
        [Key]
        public int idDepartement {  get; set; }
        
        [MaxLength(10), Required]
        public string CodeDepartement { get; set; }

        [MaxLength(80), Required]
        public string DesignationDepartement { get; set; }
    }
}
