using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject2.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepository repo;

        public EventController(IEventRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var events = repo.GetAllEvents();
            return View(events);
        }
    }
}

