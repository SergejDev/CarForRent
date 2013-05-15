using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarForRent.Models;
using CarForRent.Filters;
using PagedList;

namespace CarForRent.Controllers.Cms
{
    [Authorize(Roles = "Administrator")]
    [InitializeSimpleMembership]
    public class CmsOrderController : Controller
    {
        private DataBaseContext db = new DataBaseContext();
        const int PageSize = 5;
        //
        // GET: /CmsOrder/

        public ActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            var orders = db.Orders.Include(o => o.Auto).Include(o => o.Client);
            return View("../Order/Index",orders.ToList().ToPagedList(pageNumber, PageSize));
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

            var model = db.Autos.FirstOrDefault(m => m.AutoId == order.AutoId);

            return View("../Auto/Details", model);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}