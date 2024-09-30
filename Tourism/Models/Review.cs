using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tourism.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter UserID Plz")]
        [ForeignKey("User")]
        public int UserID {  get; set; }    
        [Required(ErrorMessage = "Enter Reting from 0 : 10 Plz")]
        public int Rating { get; set; }
        public string? ReviewText { get; set; }
        public DateOnly ReviewDate {  get; set; } = new DateOnly(); 
        public User ?User { get; set; }
    }
}
