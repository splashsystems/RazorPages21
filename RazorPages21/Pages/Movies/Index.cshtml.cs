using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie21.Data;
using RazorPagesMovie21.Models;

namespace RazorPagesMovie21.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie21.Data.RazorPagesMovie21Context _context;

        public IndexModel(RazorPagesMovie21.Data.RazorPagesMovie21Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
