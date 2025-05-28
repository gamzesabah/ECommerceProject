using System.Linq;
using System.Web.Mvc;
using ECommerceProject.Context;

namespace ECommerceProject.Controllers
{
    public class ShoesController : Controller
    {
        private readonly ECommerceProjectContext Db = new ECommerceProjectContext();

        // GET: Shoes
        public ActionResult Index()
        {
            var products = Db.Products
                             .Where(p => p.Category.CategoryName == "Ayakkabı")
                             .ToList();

            return View(products);
        }
    }
}
