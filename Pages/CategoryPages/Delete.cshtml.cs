using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lupas_Miruna_Lab2.Data;
using Lupas_Miruna_Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lupas_Miruna_Lab2.Pages.CategoryPages
{
    public class DeleteModel : PageModel
    {
        private readonly Lupas_Miruna_Lab2Context _context;

        public DeleteModel(Lupas_Miruna_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category != null)
            {
                Category = category;
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
