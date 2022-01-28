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

namespace OnlineCatalog.Pages.Grades
{
    public class DetailsModel : PageModel
    {
        private readonly OnlineCatalog.Data.OnlineCatalogContext _context;

        public DetailsModel(OnlineCatalog.Data.OnlineCatalogContext context)
        {
            _context = context;
        }

        public Grade Grade { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grade = await _context.Grade
                .Include(g => g.Student).FirstOrDefaultAsync(m => m.GradeID == id);

            if (Grade == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
