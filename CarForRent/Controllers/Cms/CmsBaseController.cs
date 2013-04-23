using CarForRent.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarForRent.Controllers
{
    [Authorize(Roles = "Administrator")]
    [InitializeSimpleMembership]
    public class CmsBaseController : Controller
    {
        //
        // GET: /CmsController/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AutoManagement()
        {
            return RedirectToAction("Index", "CmsAuto");
        }

        public ActionResult UserProfileManagement()
        {
            return RedirectToAction("Index", "CmsUserProfile");
        }
    }
}
