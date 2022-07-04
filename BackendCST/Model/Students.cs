using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndCST.Model
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID Student")]
        public int id_student { get; set; }
        [Required(ErrorMessage = "Campul este necesar")]
        [Column(TypeName = "varchar(150)")]
        [Display(Name = "Nume Student")]
        public string nume { get; set; }

        [Required(ErrorMessage = "Campul este necesar")]
        [Column(TypeName = "int")]
        [Range(1,4)]
        public int an { get; set; }
        [Required(ErrorMessage = "Campul este necesar")]
        [Column(TypeName = "int")]
        [Range(1, 5)]
        public int grupa { get; set; }
    }
}
