using ECommerceProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Controllers
{
    public class BagsController : Controller
    {
        // GET: Bags
        private readonly ECommerceProjectContext Db = new ECommerceProjectContext();

        public ActionResult Index()
        {
            var products = Db.Products
                             .Where(p => p.Category.CategoryName == "Çanta")
                             .ToList();

            return View(products);
        }
    }
}