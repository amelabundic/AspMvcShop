using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspMvcShop.Models;
using AspMvcShop.Services;

namespace AspMvcShop.Controllers
{
    public class KorpaController : Controller
    {
      
            private readonly WebshopContext db;
            private KorpaServis kServis;
            private Korpa korpa;

        public KorpaController(WebshopContext _db, KorpaServis _kServis)
            {
                kServis = _kServis;
                db = _db;
                korpa = kServis.CitajKorpu();
            }

            public IActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(korpa);
        }

        public IActionResult DodajStavku(int ProizvodId, string returnUrl)
        {
            Proizvod p1 = db.Proizvodi.Find(ProizvodId);
            if (p1 != null)
            {
                korpa.DodajStavku(p1, 1);
                kServis.CuvajKorpu(korpa);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult ObrisiStavku(int ProizvodId, string returnUrl)
        {
            Proizvod p1 = db.Proizvodi.Find(ProizvodId);
            if (p1 != null)
            {
                korpa.ObrisiStavku(p1);
                kServis.CuvajKorpu(korpa);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult PromeniStavku(int ProizvodId, int kolicina, string returnUrl)
        {
            Proizvod proizvod = db.Proizvodi.Find(ProizvodId);
            if (proizvod != null)
            {
                korpa.PromeniStavku(proizvod, kolicina);
                kServis.CuvajKorpu(korpa);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

    }
}