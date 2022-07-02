using eTickets.Data;
using eTickets.Data.Services;
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
    }
}
