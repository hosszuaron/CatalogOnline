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

namespace OnlineCatalog.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly OnlineCatalog.Data.OnlineCatalogContext _context;

        public IndexModel(OnlineCatalog.Data.OnlineCatalogContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student
                .Include(s => s.Specialization).ToListAsync();
        }
    }
}
