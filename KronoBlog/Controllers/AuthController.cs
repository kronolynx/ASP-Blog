using KronoBlog.ViewModels;  // important to use our ViewModels 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KronoBlog.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            if (form.Username.Length < 5)
            {
                // we can use our own validation and generate our own errors
                ModelState.AddModelError("Username", "Username must be longer than 5 characters");
                return View(form);
            }
            return Content("hello " + form.Username);
        }
    }
}