using EcolePoleDance.Models;
using EcolePoleDance.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcolePoleDance.Web.Infra;

namespace EcolePoleDance.Web.Controllers
{
    public class AccountController : Controller
    {
        DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                ClientModel cm = ctx.ClientAuth(lm);
                if (cm == null)
                {
                    ViewBag.ErrorNotExistent = "Erreur Login/Password";
                    return View();
                }
                else if (lm.Email == "poleisart@gmail.org" && lm.Password == "test1234")
                {
                    SessionUtils.IsLogged = true;
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {
                    SessionUtils.IsLogged = true;
                    SessionUtils.ConnectedUser = cm;
                    return RedirectToAction("Index", "Home", new { area = "Membre" });
                }
            }
            else
            {
                ViewBag.ErrorNotValid = "Formulaire error : vérifiez les données insérées et réessayez";
                return View();
            }

        }
    }
}