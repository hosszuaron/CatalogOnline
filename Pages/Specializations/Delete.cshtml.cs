#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineCatalog.Data;
using OnlineCatalog.Models;

namespace OnlineCatalog.Pages.Specializations
{
    public class DeleteModel : PageModel
    {
        private readonly OnlineCatalog.Data.OnlineCatalogContext _context;

        public DeleteModel(OnlineCatalog.Data.OnlineCatalogContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Specialization Specialization { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specialization = await _context.Specialization.FirstOrDefaultAsync(m => m.SpecializationID == id);

            if (Specialization == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specialization = await _context.Specialization.FindAsync(id);

            if (Specialization != null)
            {
                _context.Specialization.Remove(Specialization);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
