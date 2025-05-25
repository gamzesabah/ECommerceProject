using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class CategoryController : Controller
    {
        ECommerceProjectContext Db = new ECommerceProjectContext();
        // GET: Category

        public ActionResult Index()
        {
            var value = Db.Categories.ToList();
            return View(value);
        }
        public ActionResult CategoryList()
        {
            var value = Db.Categories.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryCreate(Category model)
        {
            Db.Categories.Add(model);
            Db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult CategoryEdit(int id)
        {
            var value = Db.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult CategoryEdit(Category model)
        {
            var values = Db.Categories.Find(model.CategoryId);
            values.CategoryName = model.CategoryName;
            Db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public ActionResult CategoryDelete(int id)
        {
            var values = Db.Categories.Find(id);
            Db.Categories.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}