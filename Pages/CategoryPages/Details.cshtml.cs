using Lupas_Miruna_Lab2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lupas_Miruna_Lab2.Models;

namespace Lupas_Miruna_Lab2.Pages.CategoryPages
{
    public class DetailsModel : PageModel
    {
        private readonly Lupas_Miruna_Lab2Context _context;

        public DetailsModel(Lupas_Miruna_Lab2Context context)
        {
            _context = context;
        }
        
        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (category is not null)
            {
                Category = category;

                return Page();
            }

            return NotFound();
        }
    }
}
