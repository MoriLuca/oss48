using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using L_Email;

namespace oos48.Controllers
{
    public class BajiquanController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Corso()
        {
            ViewBag.Message = "Corso";

            return View();
        }

        public ActionResult Istruttore()
        {
            ViewBag.Message = "Istruttore";
            //L_Email.EmailSender email = new EmailSender(EmailSender.eEmailAccount.LucaGiDiAutomazione);
            //email.SendEmail("lucam@gidiautomazione.it","oss48","Ecco l'email inviata dal sito",false);
            //email = null;
            return View();
        }

        public ActionResult Orari()
        {
            ViewBag.Message = "Orari";
            return View();
        }
    }
}