using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BulkyBookWeb.Models
{
    public class Usersdata
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayName("Age")]
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public DateTime Dateofcreation { get; set; } = DateTime.Now;
       
    }
}
