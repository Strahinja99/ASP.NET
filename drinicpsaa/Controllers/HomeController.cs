using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace drinicpsaa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
            [HttpGet]
        public ActionResult FormaOcena()
        {
            return View();
        }
        [HttpPost]
        public ViewResult FormaOcena(Models.svidjanja odgovor)
        {
            return View("odgovornapitanje", odgovor);
        }

        public ActionResult Omeni()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Unesite vase podatke!";
            ViewBag.Title = "Kontaktirajte me!";
            ViewBag.kita = "caopoz";
            return View();
        }
    }
}