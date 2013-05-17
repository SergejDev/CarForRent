using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarForRent.Models;
using PagedList;

namespace CarForRent.Controllers
{
    public class AutoController : Controller
    {
        private DataBaseContext dbContext = new DataBaseContext();
        const int PageSize = 5;
        //
        // GET: /Auto/

        public ActionResult Index(int? page)
        {
            ViewBag.Title = "Auto rental system";
            var autos = dbContext.Autos.Include(a => a.AutoClass).Include(a => a.EngineType).Include(a => a.GearboxType).Include(a => a.FuelType);
            int pageNumber = page ?? 1;

            var autosList = autos.ToList().ToPagedList(pageNumber, PageSize);

            return View(autosList);
        }


        //
        // GET: /Auto/Details/5

        public ActionResult Details(int autoId = 1)
        {
            Auto auto = dbContext.Autos.Find(autoId);
            if (auto == null)
            {
                return HttpNotFound();
            }
            return View(auto);
        }



        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}