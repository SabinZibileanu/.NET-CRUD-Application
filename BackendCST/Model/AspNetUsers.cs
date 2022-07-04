using System.ComponentModel.DataAnnotations;
namespace BackEndCST.Model
{
    public class AspNetUsers
    {
        [Key]
        public string Id { get; set; }

        public string UserName { get; set; }
    }
}
