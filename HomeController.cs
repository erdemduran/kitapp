using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kitap1.Models;

namespace kitap1.Controllers;

public class HomeController : Controller
{
      public ActionResult Index()
        {
            
            var kitap = new Kitap
            {
                KitapAdı = "Sefiller",
                YazarAdı = "Victor Hugo",
                YayınlanmaTarihi = new DateTime(1862, 1, 1),
                Türü = "Roman",
                SayfaSayısı = 1234,
                Fiyat = 39.99m
            };

            
            return View(kitap);
        }
}
