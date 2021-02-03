using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspMvcShop.Models;

namespace AspMvcShop.Components
{
    public class MeniViewComponent : ViewComponent
    {
        private readonly WebshopContext db;

        public MeniViewComponent(WebshopContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            IEnumerable<string> listaKategorija = db.Proizvodi
          .Select(p => p.Kategorija).Distinct();
       
            return View(listaKategorija.ToList());
        }
    }
}
