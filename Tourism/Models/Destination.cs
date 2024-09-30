using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tourism.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name Plz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Location Plz")]
        public string Location { get; set; }
        public byte[]? Image { get; set; }
        [Required(ErrorMessage = "Enter Category ID Plz")]
        [ForeignKey("Category")]
        public int CategoryID {  get; set; }
        public Category ?Category { get; set; }

        [Required(ErrorMessage = "Enter Hotel ID Plz")]
        [ForeignKey("Hotel")]
        public int HotelID {  get; set; }
        public Hotel ? Hotel { get; set; }



    }
}
