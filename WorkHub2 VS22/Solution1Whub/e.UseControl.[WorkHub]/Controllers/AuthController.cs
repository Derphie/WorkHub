using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e.UseControl._WorkHub_.Controllers
{
    public class AuthController : Controller
    {
        // GET: SignIn
        public ActionResult SignIn()
        {
            return View();
        }
        // POST: SignIn
        [HttpPost]
        public ActionResult SignIn(string email, string password)
        {
            // Aici vei adăuga logica de autentificare
            if (email == "test@example.com" && password == "password")
            {
                return RedirectToAction("Index", "Home");
            }
            
            ViewBag.Error = "Email sau parolă incorecte.";
            return View();
        }
        // GET: SignUp
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: SignUp
        [HttpPost]
        public ActionResult SignUp(string name, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ViewBag.Error = "Parolele nu coincid!";
                return View();
            }

            // Aici poți adăuga logica pentru salvarea utilizatorului în baza de date
            ViewBag.Message = "Cont creat cu succes! Acum te poți conecta.";
            return RedirectToAction("SignIn");
        }


        }
}