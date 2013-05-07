using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarForRent.Models;
using PagedList;

namespace CarForRent.Controllers
{
    public class SearchingFilterController : Controller
    {
        DataBaseContext dbContext = new DataBaseContext();
        //
        // GET: /Filter/

        public ActionResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Index(SearchingFilter filter)
        {
            IQueryable<Auto> autos = dbContext.Autos.Select(m=>m);

            if (!String.IsNullOrEmpty(filter.EngineType))
            {
                autos = autos.Where(m => m.EngineType.EngineTypeTitle.Contains(filter.EngineType));
            }
            if (!String.IsNullOrEmpty(filter.AutoClass))
            {
                autos = autos.Where(m => m.AutoClass.ClassTitle.Contains(filter.AutoClass));
            }

            if (!String.IsNullOrEmpty(filter.FuelType))
            {
                autos = autos.Where(m => m.FuelType.FuelTypeTitle.Contains(filter.FuelType));
            }

            if (!String.IsNullOrEmpty(filter.GearboxType))
            {
                autos = autos.Where(m => m.GearboxType.GearboxTypeTitle.Contains(filter.GearboxType));
            }

            if (!String.IsNullOrEmpty(filter.Mark))
            {
                autos = autos.Where(m => m.Mark.Contains(filter.Mark));
            }

            if (!String.IsNullOrEmpty(filter.Model))
            {
                autos = autos.Where(m => m.Model.Contains(filter.Model));
            }


            if (filter.EngineVolume != null)
            {
                float volume = Convert.ToSingle(filter.EngineVolume);
                autos = autos.Where(m => m.EngineVolume <= volume);
            }

            if (filter.PlacesCount != null)
            {
                int places = Convert.ToInt16(filter.PlacesCount);
                autos = autos.Where(m => m.PlacesCount <= places);
            }

            if (filter.Price != null)
            {
                decimal price = Convert.ToInt32(filter.Price);
                autos = autos.Where(m => m.Price <= price);
            }

            if (filter.YearOfManufacture!=null)
            {
                int year = Convert.ToInt32(filter.YearOfManufacture);
                autos = autos.Where(m => m.YearOfManufacture.Value <= year);
            }

            var result = autos.ToList().ToPagedList(1,5);
            
            return View("../Auto/Index", result);
        }
        
    }
}
