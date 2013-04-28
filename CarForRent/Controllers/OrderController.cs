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
    public class OrderController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        //
        // GET: /Order/

        public ActionResult Index()
        {
            int currentUserId = db.UserProfiles.Where(o => o.UserName == User.Identity.Name).SingleOrDefault().UserId;
            var currentUserOrders = db.Orders.Where(o => o.ClientId == currentUserId).ToList();
            return View(currentUserOrders);
        }

        //
        // GET: /Order/Details/5

        public ActionResult Details(int id = 0)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        //
        // GET: /Order/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Order/Create

        [HttpPost]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(order);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}