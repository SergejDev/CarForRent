using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarForRent.Models;

namespace CarForRent.Controllers
{
    public class ManageAccountController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        //
        // GET: /ManageAccount/

        public ActionResult Index()
        {
            int id = db.UserProfiles.Where(m => m.UserName == User.Identity.Name).FirstOrDefault().UserId;
            UserProfile userprofile = db.UserProfiles.Find(id);
            if (userprofile == null)
            {
                return HttpNotFound();
            }
            return View(userprofile);
        }

        //
        // GET: /ManageAccount/Details/5

        public ActionResult Details(int id = 0)
        {
            UserProfile userprofile = db.UserProfiles.Find(id);
            if (userprofile == null)
            {
                return HttpNotFound();
            }
            return View(userprofile);
        }

        //
        // GET: /ManageAccount/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ManageAccount/Create

        [HttpPost]
        public ActionResult Create(UserProfile userprofile)
        {
            if (ModelState.IsValid)
            {
                db.UserProfiles.Add(userprofile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userprofile);
        }

        //
        // GET: /ManageAccount/Edit/5

        public ActionResult Edit()
        {
            int id = db.UserProfiles.Where(m => m.UserName == User.Identity.Name).FirstOrDefault().UserId;
            UserProfile userprofile = db.UserProfiles.Find(id);
            if (userprofile == null)
            {
                return HttpNotFound();
            }
            return View(userprofile);
        }

        //
        // POST: /ManageAccount/Edit/5

        [HttpPost]
        public ActionResult Edit(UserProfile userprofile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userprofile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userprofile);
        }




        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}