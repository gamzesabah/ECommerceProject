using System.Linq;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class ChildrenClothesController : Controller
    {
        private readonly ECommerceProjectContext Db = new ECommerceProjectContext();

        // GET: ChildrenClothes
        public ActionResult Index()
        {
            // Sadece "Çocuk" kategorisindeki ürünler
            var childrenCategoryName = "Çocuk";
            var validCategories = new[] { "Gömlek", "Tişört", "Ceket", "Pantolon" };

            var products = Db.Products
                             .Where(p => p.Category.CategoryName == childrenCategoryName &&
                                         validCategories.Contains(p.Category.CategoryName) ||
                                         validCategories.Contains(p.Name)) // Burada kategori ismi değil ürün ismi bazlı da filtreleme kontrol edebilirsin
                             .ToList();

            // Ürünlerin kategori bazında filtrelenmesi (Kategori adı product.Category.CategoryName ile kontrol)
            // Ancak burada sadece çocuk kategorisindeki ürünler zaten filtrelendi.

            return View(products);
        }
    }
}
