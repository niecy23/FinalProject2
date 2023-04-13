using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject2.Controllers
{
    public class RSVPController : Controller
    {
        private readonly IRSVPRepository repo;

        public RSVPController(IRSVPRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult RSVPIndex()
        {
            var RSVPs = repo.GetAllRSVPs();
            return View(RSVPs);
        }
    }
}

