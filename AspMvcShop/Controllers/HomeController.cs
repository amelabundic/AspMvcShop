using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspMvcShop.Models;

namespace AspMvcShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebshopContext db;

        public HomeController(WebshopContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string kategorija ="")
        {
            ViewBag.Kategorija = kategorija;

            IEnumerable<Proizvod> listaProizvoda = db.Proizvodi;

            if (kategorija !="")
            {
                listaProizvoda = listaProizvoda.Where(p=>p.Kategorija == kategorija);

            }
            return View("Index", listaProizvoda.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
