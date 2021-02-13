using EcolePoleDance.Web.Models;
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
            ViewBag.Home = "current";
            return View();
        }

        public ActionResult Cours()
        {
            ViewBag.Cours = "current";
            CoursViewModel cm = new CoursViewModel();
            return View(cm);
        }

        public ActionResult Equipe()
        {
            ViewBag.Equipe = "current";
            EquipeViewModel em = new EquipeViewModel();
            return View(em);
        }

        public ActionResult Tarifs()
        {
            ViewBag.Tarifs = "current";
            return View();
        }

        public ActionResult Inscription()
        {
            ViewBag.Inscription = "current";
            return View();
        }
    }
}