using KronoBlog.ViewModels;  // important to use our ViewModels 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KronoBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            // here should go a flash message
            return RedirectToRoute("home");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            // true is for CreatePersistenCookie
            FormsAuthentication.SetAuthCookie(form.Username, true);

            // check if we have a return url and redirect if needed
            if (!string.IsNullOrWhiteSpace(returnUrl))
                return Redirect(returnUrl);

            // redirect to home
            return RedirectToRoute("home");
        }
    }
}