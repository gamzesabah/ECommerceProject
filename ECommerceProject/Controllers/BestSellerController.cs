using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class BestSellerController : Controller
    {
        ECommerceProjectContext Db = new ECommerceProjectContext();

        // GET: BestSeller
        public ActionResult Index()
        {
            // En çok satan ürünleri örnek olarak satış sayısına göre getiriyoruz.
            // Burada Product tablosunda SalesCount diye bir sütun olduğunu varsayıyorum.
            var bestSellers = Db.Products
                                //.OrderByDescending(p => p.SalesCount) // en çok satandan azalana sıralama
                                .Take(10) // İlk 10 ürünü al
                                .ToList();

            return View(bestSellers);
        }

        // Opsiyonel: Ürün Detay Sayfası
        public ActionResult Details(int id)
        {
            var product = Db.Products.Find(id);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }
    }
}
