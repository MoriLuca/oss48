using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oos48.Controllers
{
    public class CucinaController : Controller
    {
        // GET: Cucina
        public ActionResult Ingredienti()
        {
            return View();
        }

        public ActionResult Ricette()
        {
            return View();
        }

        public ActionResult Cucina()
        {
            return View();
        }
    }
}