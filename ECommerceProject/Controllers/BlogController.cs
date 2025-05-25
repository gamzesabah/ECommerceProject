using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class BlogController : Controller
    {
        ECommerceProjectContext Db = new ECommerceProjectContext();
        // GET: Blog

        public ActionResult Index()
        {
            var value = Db.Blogs.ToList();
            return View(value);
        }
        public ActionResult BlogList()
        {
            var value = Db.Blogs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult BlogCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BlogCreate(Blog model)
        {
            Db.Blogs.Add(model);
            Db.SaveChanges();
            return RedirectToAction("BlogList");
        }
        [HttpGet]
        public ActionResult BlogEdit(int id)
        {
            var value = Db.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult BlogEdit(Blog model)
        {
            var values = Db.Blogs.Find(model.BlogId);
            values.Title = model.Title;
            values.Subtitle = model.Subtitle;
            values.Description = model.Description;
            values.ImageUrl = model.ImageUrl;
            Db.SaveChanges();
            return RedirectToAction("BlogList");
        }
        public ActionResult BlogDelete(int id)
        {
            var values = Db.Blogs.Find(id);
            Db.Blogs.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("BlogList");
        }
    }
}