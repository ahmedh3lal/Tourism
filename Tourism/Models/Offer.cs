using System.ComponentModel.DataAnnotations;

namespace Tourism.Models
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name Plz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter Start Date Plz")]
        public DateOnly StartDate { get; set; }
        [Required(ErrorMessage = "Enter End Date Plz")]
        public DateOnly EndDate { get; set; }
        public string ? Description {  get; set; }    

    }
}
