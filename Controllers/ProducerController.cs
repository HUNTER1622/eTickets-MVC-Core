using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDBContext db;
        public ProducerController(AppDBContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var producersList = await db.Producers.ToListAsync();
            return View(producersList);
        }
    }
}
