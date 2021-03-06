#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineCatalog.Data;
using OnlineCatalog.Models;

namespace OnlineCatalog.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly OnlineCatalog.Data.OnlineCatalogContext _context;

        public CreateModel(OnlineCatalog.Data.OnlineCatalogContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SpecializationID"] = new SelectList(_context.Specialization, "SpecializationID", "SpecializationName");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
