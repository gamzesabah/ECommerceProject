using ECommerceProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ECommerceProject.Controllers
{
    public class ManClothesController : Controller
    {
        private readonly ECommerceProjectContext Db = new ECommerceProjectContext();

        public ActionResult Index()
        {
            var products = Db.Products
                             .Where(p => p.Category.CategoryName == "Erkek")
                             .ToList();

            return View(products);
        }
    }
}
