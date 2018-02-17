using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oss48.Controllers
{
    public class CucinaController : Controller
    {
        // GET: Cucina
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ingredienti()
        {
            List<DB.Cucina.tipoprodotto> i = new List<DB.Cucina.tipoprodotto>();
            using (var context = new DB.Cucina.cucinaEntities())
            {
                i = context.tipoprodotto.ToList();
            }
            return View(i[0]);
        }

    }
}