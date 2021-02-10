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
            return View();
        }

        public ActionResult Cours()
        {
            return View();
        }

        public ActionResult Equipe()
        {
            return View();
        }

        public ActionResult Tarifs()
        {
            return View();
        }
    }
}