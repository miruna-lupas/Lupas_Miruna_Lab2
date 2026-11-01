using System.ComponentModel.DataAnnotations;

namespace Lupas_Miruna_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; } = string.Empty;

        [ScaffoldColumn(false)]
        public ICollection<Book>? Books { get; set; }
    }
}