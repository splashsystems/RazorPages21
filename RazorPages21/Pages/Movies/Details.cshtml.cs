﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie21.Data.RazorPagesMovie21Context _context;

        public DetailsModel(RazorPagesMovie21.Data.RazorPagesMovie21Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}