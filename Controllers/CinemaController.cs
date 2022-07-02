using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDBContext db;
        public CinemaController(AppDBContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var cinamalist = db.Cinemas.ToList();
            return View(cinamalist);
        }
    }
}
