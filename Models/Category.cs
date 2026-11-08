using System.ComponentModel.DataAnnotations;

namespace Lupas_Miruna_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        
        [Display(Name = "Category Name")]
        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}