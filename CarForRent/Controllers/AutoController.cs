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
    public class AutoController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        //
        // GET: /Auto/

        public ActionResult Index()
        {
            var autos = db.Autos.Include(a => a.AutoClass).Include(a => a.EngineType).Include(a => a.GearboxType).Include(a => a.FuelType);
            return View(autos.ToList());
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