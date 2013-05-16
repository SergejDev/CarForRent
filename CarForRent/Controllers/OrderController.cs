using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarForRent.Models;
using CarForRent.Filters;
using CarForRent.Helpers;

namespace CarForRent.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
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
            var model = db.Autos.FirstOrDefault(m => m.AutoId == order.AutoId);

            return View("../Auto/Details", model);
        }

        //
        // GET: /Order/Create

        public ActionResult Create(int? autoId)
        {
            var currentUser = db.UserProfiles.SingleOrDefault(u => u.UserName == User.Identity.Name);
            
            if (CustomValidators.ValidatePersonalInformation(currentUser))
            {
                autoId = autoId ?? 1;
                ViewBag.CurrentAuto = db.Autos.SingleOrDefault(a => a.AutoId == autoId);
                return View();
            }
            else
            {
                ViewBag.Message = "First fill your personal information";
                return RedirectToAction("Edit", "ManageAccount");
            }
        }

        //
        // POST: /Order/Create

        [HttpPost]
        public ActionResult Create(Order order)
        {
            var orderedAuto = db.Autos.SingleOrDefault(a => a.AutoId == order.AutoId);
            if (!CustomValidators.ValidateAutosCount(orderedAuto))
            {
                ModelState.AddModelError("AutosCount", "No more cars");
            }

            if (ModelState.IsValid)
            {
                orderedAuto.AutoCount -= 1;
                db.Entry(orderedAuto).State = EntityState.Modified;

                order.ClientId = db.UserProfiles.SingleOrDefault(u => u.UserName == User.Identity.Name).UserId;
                order.OrderDate = DateTime.Now;
                order.IsOpen = true;

                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CurrentAuto = orderedAuto;
            return View(order);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}