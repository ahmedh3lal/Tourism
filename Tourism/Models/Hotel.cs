using System.ComponentModel.DataAnnotations;

namespace Tourism.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name Plz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Address Plz")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter Price of Night Plz")]
        public decimal PriceofNight {  get; set; }  

        public int? Rating { get; set; }
    }
}
