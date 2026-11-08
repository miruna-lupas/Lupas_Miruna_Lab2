using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lupas_Miruna_Lab2.Data;
using Lupas_Miruna_Lab2.Models;

namespace Lupas_Miruna_Lab2.Pages.CategoryPages
{
    public class IndexModel : PageModel
    {
        private readonly Lupas_Miruna_Lab2Context _context;

        public IndexModel(Lupas_Miruna_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
