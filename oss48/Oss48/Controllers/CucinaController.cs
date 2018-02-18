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

        public ActionResult TipoProdotto( List<DB.Cucina.tipoprodotto> listaTipiProdotti )
        {
            // Linee aggiunte o modificate sul database
            ViewData["SaveChange"] = 0;
            ViewData["ErrorMessage"] = null;

            if (Request.HttpMethod == "POST")
            {
                using (var context = new DB.Cucina.cucinaEntities())
                {
                    try
                    {
                        context.tipoprodotto.Add(listaTipiProdotti.Last());
                        // Tengo nota del numero di linee aggiornate sul db
                        ViewData["SaveChange"] = context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ViewData["SaveChange"] = -1;
                        ViewData["ErrorMessage"] = ex.InnerException.InnerException.Message;
                        if (ViewData["ErrorMessage"].ToString().Contains("Duplicate"))
                            ViewData["ErrorMessage"] = "Tipo Prodotto gia esistente.";
                        
                    }
                    
                }
            }


            List<DB.Cucina.tipoprodotto> i = new List<DB.Cucina.tipoprodotto>();
            using (var context = new DB.Cucina.cucinaEntities())
            {
                i = context.tipoprodotto.ToList();
            }
            return View(i);
        }

    }
}