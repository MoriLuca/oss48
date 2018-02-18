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
            return View(i);
        }

        public ActionResult TipoProdotto(List<DB.Cucina.tipoprodotto> listaTipiProdotti)
        {
            // Linee aggiunte o modificate sul database
            ViewData["SaveChange"] = 0;
            ViewData["ErrorMessage"] = null;

            List<DB.Cucina.tipoprodotto> i = new List<DB.Cucina.tipoprodotto>();
            using (var context = new DB.Cucina.cucinaEntities())
            {
                i = context.tipoprodotto.ToList();
            }
            return View(i);
        }

        public PartialViewResult SearchTipoProdotto(string nome)
        {
            List<DB.Cucina.tipoprodotto> list = new List<DB.Cucina.tipoprodotto>();
            if (Request.HttpMethod == "POST")
            {
                using (var context = new DB.Cucina.cucinaEntities())
                {
                    list = context.tipoprodotto.Where(p=>p.Nome.Contains(nome)).ToList();
                }
            }
            return PartialView(list);
        }
    }
}