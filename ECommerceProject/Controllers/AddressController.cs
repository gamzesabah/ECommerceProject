using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class AddressController : Controller
    {
        ECommerceProjectContext Db = new ECommerceProjectContext();
        // GET: Address

        public ActionResult Index()
        {
            var value = Db.Addresses.ToList();
            return View(value);
        }
        public ActionResult AddressList()
        {
            var value = Db.Addresses.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddressCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddressCreate(Address model)
        {
            Db.Addresses.Add(model);
            Db.SaveChanges();
            return RedirectToAction("AddressList");
        }
        [HttpGet]
        public ActionResult AddressEdit(int id)
        {
            var value = Db.Addresses.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult AddressEdit(Address model)
        {
            var values = Db.Addresses.Find(model.AddressId);
            values.Location = model.Location;
            values.Email = model.Email;
            values.Call = model.Call;
            Db.SaveChanges();
            return RedirectToAction("AddressList");
        }
        public ActionResult AddressDelete(int id)
        {
            var values = Db.Addresses.Find(id);
            Db.Addresses.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("AddressList");
        }
    }
}