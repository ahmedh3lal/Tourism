using System.ComponentModel.DataAnnotations;

namespace Tourism.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter FullName Plz")]
        public string Name { get; set; }

    }
}
