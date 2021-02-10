using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcolePoleDance.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Home = "active";
            return View();
        }

        public ActionResult Cours()
        {
            ViewBag.Cours = "active";
            return View();
        }

        public ActionResult Equipe()
        {
            ViewBag.Equipe = "active";
            return View();
        }

        public ActionResult Tarifs()
        {
            ViewBag.Tarifs = "active";
            return View();
        }

        public ActionResult Inscription()
        {
            ViewBag.Inscription = "active";
            return View();
        }
    }
}