using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject2.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository repo;

        public UserController(IUserRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult UserIndex()
        {
            var users = repo.GetAllUsers();
            return View(users);
        }

        public IActionResult ViewUser(int id)
        {
            var user = repo.GetUser(id);
            return View(user);
        }

        public IActionResult UpdateUser(int id)
        {
            User user = repo.GetUser(id);
            if (user == null)
            {
                return View("UserNotFound");
            }
            return View(user);
        }

        public IActionResult UpdateUserToDatabase(User user)
        {
            repo.UpdateUser(user);

            return RedirectToAction("ViewUser", new { id = user.UserID });
        }

        public IActionResult InsertUser()
        {
            var user = repo.AssignEvent();
            return View(user);
        }

        public IActionResult InsertUserToDatabase(User userToInsert)
        {
            repo.InsertUser(userToInsert);
            return RedirectToAction("UserIndex");
        }

        public IActionResult DeleteUser(User user)
        {
            repo.DeleteUser(user);
            return RedirectToAction("UserIndex");
        }
    }
}

