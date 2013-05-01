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
        private DataBaseContext db = new DataBaseContext();
        const int PageSize = 5;
        //
        // GET: /Auto/

        public ActionResult Index(int? page)
        {
            var autos = db.Autos.Include(a => a.AutoClass).Include(a => a.EngineType).Include(a => a.GearboxType).Include(a => a.FuelType);
            int pageNumber = page ?? 1;
            
            var autosList = autos.ToList();

            return View(autosList.ToPagedList(pageNumber,PageSize));
        }


        //
        // GET: /Auto/Details/5

        public ActionResult Details(int id = 1)
        {
            Auto auto = db.Autos.Find(id);
            if (auto == null)
            {
                return HttpNotFound();
            }
            return View(auto);
        }

        

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}