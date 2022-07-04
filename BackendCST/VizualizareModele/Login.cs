using System.ComponentModel.DataAnnotations;

namespace BackEndCST.VizualizareModele
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool tine_minte { get; set; }
    }
}
