using System.Linq;
using System.Web.Mvc;
using ECommerceProject.Context;

namespace ECommerceProject.Controllers
{
    public class ChildrenClothesController : Controller
    {
        private readonly ECommerceProjectContext Db = new ECommerceProjectContext();

        // GET: ChildrenClothes
        public ActionResult Index()
        {
            var products = Db.Products
                             .Where(p => p.Category.CategoryName == "Çocuk")
                             .ToList();

            return View(products);
        }
    }
}

