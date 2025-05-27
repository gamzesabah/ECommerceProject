using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class NewSeasonController : Controller
    {
        ECommerceProjectContext Db = new ECommerceProjectContext();

        // GET: NewSeason
        public ActionResult Index()
        {
            // Yeni sezon ürünlerini filtreleyip getiriyoruz
            var newSeasonProducts = Db.Products
                                     .Where(p => p.IsNewSeason) // yeni sezon ürünleri
                                     .ToList();

            return View(newSeasonProducts);
        }

        // Opsiyonel: Ürün Detay sayfası
        public ActionResult Details(int id)
        {
            var product = Db.Products.Find(id);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }
    }
}
