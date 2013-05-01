using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarForRent.Models;
using CarForRent.Filters;

namespace CarForRent.Controllers.Cms
{
    [Authorize(Roles = "Administrator")]
    [InitializeSimpleMembership]
    public class CmsOrderController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        //
        // GET: /CmsOrder/

        public ActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Auto).Include(o => o.Client);
            return View("../Order/Index", orders.ToList());
        }

        //
        // GET: /CmsOrder/Details/5

        public ActionResult Details(int id = 0)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View("../Order/Details", order);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}