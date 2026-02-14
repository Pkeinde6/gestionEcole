using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    public class Utilisateur
    {
        [Key]
        public int IdU { get; set; }

        [MaxLength(80), Required]
        public string NomU { get; set; }

        [MaxLength(80), Required]
        public string PrenomU { get; set; }

        [MaxLength(10), Required]
        public string CodeU { get; set; }

        [MaxLength(200), Required]
        public string AdresseU { get; set; }

        [MaxLength(80), DataType(DataType.EmailAddress), Required]
        public string EmailU { get; set; }

        [MaxLength(20), Required]
        public string PhoneU { get; set; }

        [MaxLength(255), Required]
        public string MotDePasse { get; set; }  
    }
}
