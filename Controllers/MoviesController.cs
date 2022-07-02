using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBContext db;
        public MoviesController(AppDBContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var MoviesList = await db.Movies.ToListAsync();
            return View(MoviesList);
        }
        public IActionResult MovieCardView()
        {
            var MoviesList =  db.Movies.Include(m=> m.Cinema).ToList();
            return View(MoviesList);
        }
    }
}
