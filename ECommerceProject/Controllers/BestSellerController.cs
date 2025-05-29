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
            var categories = new[] { "Kadın", "Erkek", "Çocuk" };

            var bestSellers = Db.Products
                .Where(p => categories.Contains(p.Category.CategoryName))
                .GroupBy(p => p.Category.CategoryName)
                .SelectMany(g => g.OrderByDescending(p => p.ProductId).Take(10)) // En son eklenen 10 ürün
                .ToList();

            return View(bestSellers);
        }
    }
}
