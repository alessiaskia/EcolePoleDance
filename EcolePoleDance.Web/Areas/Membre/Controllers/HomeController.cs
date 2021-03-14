using EcolePoleDance.Models;
using EcolePoleDance.Repositories;
using EcolePoleDance.Web.Infra;
using EcolePoleDance.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        //Reservations = afficher abonnements in select
        [HttpGet]
        public ActionResult Abonnements()
        {
            TarifsViewModel tvm = new TarifsViewModel();
            return View(tvm);
        }

        //envoyer abonnement choisi dans select
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Abonnements(ClientAbonnementModel form)
        {
            if (ModelState.IsValid) //validation coté serveur vs. annotations
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (ctx.CreateInstanceAbonnement(form))
                {
                    ViewBag.SuccessMessage = "Votre choix a été enregistré et sera validé dès que vous avez payé votre abonnement";
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Votre choix n'a pas été enregistré";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorNotSelected = "Erreur : pas de sélection effectuée";
                return View();
            }
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