﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject2.Models;
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

        public IActionResult ViewEvent(int id)
        {
            var instance = repo.GetEvent(id);
            return View(instance);
        }

        public IActionResult UpdateEvent(int id)
        {
            Event instance = repo.GetEvent(id);
            if (instance == null)
            {
                return View("EventNotFound");
            }
            return View(instance);
        }

        public IActionResult UpdateEventToDatabase(Event instance)
        {
            repo.UpdateEvent(instance);

            return RedirectToAction("ViewEvent", new { id = instance.EventID });
        }

        public IActionResult InsertEvent(Event instanceToInsert)
        {
            repo.InsertEvent(instanceToInsert);
            return View(instanceToInsert);
        }

        public IActionResult InsertEventToDatabase(Event instanceToInsert)
        {
            repo.InsertEvent(instanceToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEvent(Event instance)
        {
            repo.DeleteEvent(instance);
            return RedirectToAction("Index");
        }

    }
}

