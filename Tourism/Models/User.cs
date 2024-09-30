using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tourism.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter FullName Plz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Email Plz")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Password Plz"),MinLength(7)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter PhoneNumber Plz"),MaxLength(11),MinLength(11)]
        public string PhoneNumber { get; set; } 
        public DateOnly DateOfJoin { get; set; }=new DateOnly();  
    }
}
