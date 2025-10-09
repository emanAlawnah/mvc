using System.ComponentModel.DataAnnotations;

namespace session1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required!!")]
        [MinLength(3,ErrorMessage ="the Category should be at least 3 char")]
        [MaxLength(20,ErrorMessage = "Category length cant be more than 20 char")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required!!")]
        [MinLength (20, ErrorMessage = "the Category should be at least 20 char")]
        public string Description { get; set; }

    }
}
