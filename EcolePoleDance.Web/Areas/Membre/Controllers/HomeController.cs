using EcolePoleDance.Web.Infra;
using EcolePoleDance.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcolePoleDance.Web.Areas.Membre.Controllers
{
    public class HomeController : Controller
    {
        // GET: Member/Home
        public ActionResult Index()
        {
            if (!SessionUtils.IsLogged) return RedirectToAction("Login", "Account", new { area = "" });
            return View(SessionUtils.ConnectedUser);
        }

        //Reservations = abonnements
        public ActionResult Abonnements()
        {
            TarifsViewModel tvm = new TarifsViewModel();
            return View(tvm);
        }

        //Reservations = sessions de cours
        public ActionResult SessionsCours()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}