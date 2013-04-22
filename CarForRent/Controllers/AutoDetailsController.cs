using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarForRent.Models;

namespace CarForRent.Controllers
{
    public class AutoDetailsController : Controller
    {
       
        //
        // GET: /AutoDetails/

        public ActionResult AutoDetails(int id = 2)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var auto  = dbContext.Autos.FirstOrDefault(x=>x.AutoId == id);
            return View(auto);
        }

    }
}
