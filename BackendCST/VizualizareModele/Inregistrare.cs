using System.ComponentModel.DataAnnotations;

namespace BackEndCST.VizualizareModele
{
    public class Inregistrare
    {   [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(password),ErrorMessage = "Parola confirmata nu corespunde cu parola introdusa initial")]
        public string confirm_password { get; set; }

       
    }
}
