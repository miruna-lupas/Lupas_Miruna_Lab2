using System.ComponentModel.DataAnnotations;

namespace Lupas_Miruna_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        
        [Display(Name = "First Name")]
        [StringLength(1000)]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Book>? Books { get; set; }
    }
}