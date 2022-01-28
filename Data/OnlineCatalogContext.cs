#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineCatalog.Models;

namespace OnlineCatalog.Data
{
    public class OnlineCatalogContext : DbContext
    {
        public OnlineCatalogContext (DbContextOptions<OnlineCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineCatalog.Models.Specialization> Specialization { get; set; }

        public DbSet<OnlineCatalog.Models.Student> Student { get; set; }

        public DbSet<OnlineCatalog.Models.Grade> Grade { get; set; }
    }
}
