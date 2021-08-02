using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie21.Models;

namespace RazorPagesMovie21.Data
{
    public class RazorPagesMovie21Context : DbContext
    {
        public RazorPagesMovie21Context (DbContextOptions<RazorPagesMovie21Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie21.Models.Movie> Movie { get; set; }
    }
}
