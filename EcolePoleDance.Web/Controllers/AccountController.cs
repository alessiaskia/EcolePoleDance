using EcolePoleDance.Models;
using EcolePoleDance.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hbehr.recaptcha;
using NetFlask.Infra;

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
            string userResponse = HttpContext.Request.Params["g-recaptcha-response"];
            bool validCaptcha = ReCaptcha.ValidateCaptcha(userResponse);
            if (validCaptcha)
            {
                if (ModelState.IsValid)
                {
                   ClientModel cm = ctx.UserAuth(lm);
                    if (cm == null)
                    {
                        ViewBag.Error = "Erreur Login/Password";
                        return View();
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
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }