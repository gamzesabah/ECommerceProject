using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class FeatureController : Controller
    {
        ECommerceProjectContext Db = new ECommerceProjectContext();

        // GET: Feature
        public ActionResult Index()
        {
            var value = Db.Features.ToList();
            return View(value);
        }

        public ActionResult FeatureList()
        {
            var value = Db.Features.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult FeatureCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FeatureCreate(Feature model)
        {
            Db.Features.Add(model);
            Db.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        [HttpGet]
        public ActionResult FeatureEdit(int id)
        {
            var value = Db.Features.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult FeatureEdit(Feature model)
        {
            var values = Db.Features.Find(model.FeatureId);
            values.Title = model.Title;
            values.ImageUrl = model.ImageUrl;
            Db.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        public ActionResult FeatureDelete(int id)
        {
            var values = Db.Features.Find(id);
            Db.Features.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        // ✅ Eklenen kısım: Partial View Action
        public PartialViewResult PartialFeature()
        {
            var values = Db.Features.ToList();
            return PartialView(values); // Views/Feature/PartialFeature.cshtml dosyasına gider
        }
    }
}
