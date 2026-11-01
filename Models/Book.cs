namespace Lupas_Miruna_Lab2.Models
{ 
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}