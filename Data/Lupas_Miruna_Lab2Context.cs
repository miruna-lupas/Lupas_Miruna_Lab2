using Microsoft.EntityFrameworkCore;
using Lupas_Miruna_Lab2.Models;

namespace Lupas_Miruna_Lab2.Data
{
    public class Lupas_Miruna_Lab2Context : DbContext
    {
        public Lupas_Miruna_Lab2Context(DbContextOptions<Lupas_Miruna_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
        
        public DbSet<Publisher> Publisher { get; set; } = default!;
        
        public DbSet<Author> Author { get; set; } = default!;
    }
}