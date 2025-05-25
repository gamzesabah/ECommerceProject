﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceProject.Context;
using ECommerceProject.Entities;

namespace ECommerceProject.Controllers
{
    public class ContactController : Controller
    {
        ECommerceProjectContext Db = new ECommerceProjectContext();
        // GET: Contact

        public ActionResult Index()
        {
            var value = Db.Contacts.ToList();
            return View(value);
        }
        public ActionResult ContactList()
        {
            var value = Db.Contacts.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult ContactCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactCreate(Contact model)
        {
            Db.Contacts.Add(model);
            Db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public ActionResult ContactEdit(int id)
        {
            var value = Db.Contacts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult ContactEdit(Contact model)
        {
            var values = Db.Contacts.Find(model.ContactId);
            values.Name = model.Name;
            values.Email = model.Email;
            values.Subject = model.Subject;
            Db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        public ActionResult ContactDelete(int id)
        {
            var values = Db.Contacts.Find(id);
            Db.Contacts.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}