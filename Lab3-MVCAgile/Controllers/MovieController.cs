using Lab3_MVCAgile.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab3_MVCAgile.Controllers
{
    public class MovieController : Controller
    {
        private readonly Lab3_MVCAgileContext _context;

        public MovieController(Lab3_MVCAgileContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Movie == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var movies = from m in _context.Movie
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title!.Contains(searchString));
            }

            return View(await movies.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}
