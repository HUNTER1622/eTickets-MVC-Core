using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorServices sr;
        public ActorController(IActorServices _service)
        {
            sr = _service;
        }
        public IActionResult Index()
        {
            return View(sr.GetAllActor());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Actor model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            sr.AddActor(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var data = sr.GetActorById(id);
            return View(data);
        }
    }
}
