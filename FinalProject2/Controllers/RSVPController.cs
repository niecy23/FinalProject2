using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject2.Models;
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
            var rsvps = repo.GetAllRSVPs();
            return View(rsvps);
        }

        public IActionResult ViewRSVP(int id)
        {
            var RSVP = repo.GetRSVP(id);
            return View(RSVP);
        }

        public IActionResult UpdateRSVP(int id)
        {
            RSVP RSVP = repo.GetRSVP(id);
            if (RSVP == null)
            {
                return View("RSVPNotFound");
            }
            return View(RSVP);
        }

        public IActionResult UpdateRSVPToDatabase(RSVP rSVP)
        {
            repo.UpdateRSVP(rSVP);

            return RedirectToAction("ViewRSVP", new { id = rSVP.RSVPID });
        }

        public IActionResult InsertRSVP()
        {
            var rSVP = new RSVP();
            return View(rSVP);
        }

        public IActionResult InsertRSVPToDatabase(RSVP rSVPToInsert)
        {
            repo.InsertRSVP(rSVPToInsert);
            return RedirectToAction("RSVPIndex");
        }

        public IActionResult DeleteRSVP(RSVP rSVP)
        {
            repo.DeleteRSVP(rSVP);
            return RedirectToAction("RSVPIndex");
        }
    }
}

