﻿using EcolePoleDance.Models;
using EcolePoleDance.Repositories;
using EcolePoleDance.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
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
            TarifsViewModel tm = new TarifsViewModel();
            return View(tm);
        }

        //Afficher le formulaire
        [HttpGet]
        public ActionResult Inscription()
        {
            ViewBag.Inscription = "current";
            return View();
        }

        //envoyer le formulaire
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inscription(ClientModel form) //ici l'action et la view ont le meme nom (dans la ++ des cas)
        {
            if (ModelState.IsValid) //validation coté serveur vs. annotations
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (ctx.CreateClient(form))
                {
                    ViewBag.SuccessMessage = "Votre demande d'inscription a bien été envoyée";
                    sendEmail(form);
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Message non enregistré";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error : vérifiez les données insérées et réessayez";
                return View();
            }
        }

        private void sendEmail(ClientModel form)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(form.Email);
            mail.From = new MailAddress("a.scaccia@interface3.be");
            mail.Subject = "Nouvelle demande d'inscription";
            string Body = $"<h1>{form.Prenom} {form.Nom} veut d'inscrire à Pole Is Art </h1>";
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("user", "password"); // Enter senders User name and password  
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur mail : " + ex.Message);
            }
        }
    }
}