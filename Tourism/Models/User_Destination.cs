using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tourism.Models
{
    public class User_Destination
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter User ID Plz")]
        [ForeignKey("User")]
        public int UserID { get; set; } 
        [Required(ErrorMessage = "Enter Destination ID Plz")]
        [ForeignKey("destination")]
        public int DestinationID { get; set; } 
        public User ?User { get; set; }
        public Destination ?destination { get; set; }
        public DateOnly DateOfDestination { get; set; } = new DateOnly();

    }
}
