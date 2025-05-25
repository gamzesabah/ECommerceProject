using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class DefaultController : Controller
    {
        ECommerceProjectContext Db = new ECommerceProjectContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialTop()
        {
            ViewBag.Call = Db.Addresses.Select(x => x.Call).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            var categories = Db.Categories.ToList(); 
            return PartialView(categories);
        }

        public PartialViewResult PartialFeature()
        {
            var features = Db.Features.ToList(); 
            return PartialView(features);        
        }


        public PartialViewResult PartialAbout()
        {
            var about = Db.Abouts.FirstOrDefault();
            return PartialView(about);
        }

        public PartialViewResult PartialContact()
        {
            return PartialView(); 
        }

        public PartialViewResult PartialProduct()
        {
            var products = Db.Products.ToList();
            return PartialView(products);
        }
        public PartialViewResult PartialBanner()
        {
            var banners = Db.Banners.ToList();
            return PartialView(banners);
        }

        public PartialViewResult PartialCategory()
        {
            var categories = Db.Categories.ToList();
            return PartialView(categories);
        }

        public PartialViewResult PartialBlog()
        {
            var blogs = Db.Blogs.ToList();
            return PartialView(blogs);
        }

        public PartialViewResult PartialAddress()
        {
            var address = Db.Addresses.FirstOrDefault();
            return PartialView(address);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}
