using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDBContext db;
        public ActorController(AppDBContext _context)
        {
            db = _context;
        }
        public IActionResult Index()
        {
            var list = db.Actors.ToList();
            return View(list);
        }
    }
}
