using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JaseOne.Data;
using JaseOne.Models;

namespace JaseOne.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly JaseOne.Data.JaseOneContext _context;

        public IndexModel(JaseOne.Data.JaseOneContext context)
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
