using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GettingStartedWebApp.Data;
using GettingStartedWebApp.Models;

namespace GettingStartedWebApp.Pages_Movies
{
    public class IndexModel : PageModel
    {
        private readonly GettingStartedWebApp.Data.RazorPagesMovieContext _context;

        public IndexModel(GettingStartedWebApp.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
