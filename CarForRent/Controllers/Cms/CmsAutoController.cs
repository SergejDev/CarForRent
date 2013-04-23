﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarForRent.Models;
using CarForRent.Filters;
using CarForRent.Helpers;

namespace CarForRent.Controllers.Cms
{
    [Authorize(Roles = "Administrator")]
    [InitializeSimpleMembership]
    public class CmsAutoController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        //
        // GET: /Auto/

        public ActionResult Index()
        {
            return View(db.Autos.ToList());
        }

        //
        // GET: /Auto/Details/5

        public ActionResult Details(int id = 0)
        {
            Auto auto = db.Autos.Find(id);
            if (auto == null)
            {
                return HttpNotFound();
            }
            return View(auto);
        }

        //
        // GET: /Auto/Create

        public ActionResult Create()
        {
            SelectedListBuilder listBuilder = new SelectedListBuilder();
            ViewBag.EngineTypeItems = listBuilder.EngineTypeListItems();
            ViewBag.GearboxTypeItems = listBuilder.GearboxTypeListItems();
            ViewBag.FuelTypeItems = listBuilder.FuelTypeListItems();
            return View();
        }

        //
        // POST: /Auto/Create

        [HttpPost]
        public ActionResult Create(Auto auto)
        {
            if (ModelState.IsValid)
            {
                db.Autos.Add(auto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auto);
        }

        //
        // GET: /Auto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Auto auto = db.Autos.Find(id);
            if (auto == null)
            {
                return HttpNotFound();
            }
            return View(auto);
        }

        //
        // POST: /Auto/Edit/5

        [HttpPost]
        public ActionResult Edit(Auto auto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auto);
        }

        //
        // GET: /Auto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Auto auto = db.Autos.Find(id);
            if (auto == null)
            {
                return HttpNotFound();
            }
            return View(auto);
        }

        //
        // POST: /Auto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Auto auto = db.Autos.Find(id);
            db.Autos.Remove(auto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}