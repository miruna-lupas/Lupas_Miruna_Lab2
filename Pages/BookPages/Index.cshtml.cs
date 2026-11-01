using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lupas_Miruna_Lab2.Data;
using Lupas_Miruna_Lab2.Models;

namespace Lupas_Miruna_Lab2.Pages.BookPages
{
    public class IndexModel : PageModel
    {
        private readonly Lupas_Miruna_Lab2Context _context;

        public IndexModel(Lupas_Miruna_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}