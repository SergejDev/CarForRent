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
using PagedList;
using System.IO;

namespace CarForRent.Controllers.Cms
{
    [Authorize(Roles = "Administrator")]
    [InitializeSimpleMembership]
    public class CmsAutoController : Controller
    {
        private DataBaseContext db = new DataBaseContext();
        const int PageSize = 5;
        //
        // GET: /Auto/

        public ActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;

            return View("../Auto/Index", db.Autos.ToList().ToPagedList(pageNumber,PageSize));
        }

        //
        // GET: /Auto/Details/5

        public ActionResult Details(int id = 0)
        {
            Auto auto = db.Autos.Find(id);
            if (auto == null)
            {
                return HttpNotFound();
            }
            return View("../Auto/Details", auto);
        }

        //
        // GET: /Auto/Create

        public ActionResult Create()
        {
            ComboBoxPopulator.PopulateAutoComboBoxes(ViewBag);
            return View("../Auto/Create");
        }

        //
        // POST: /Auto/Create

        [HttpPost]
        public ActionResult Create(Auto auto, HttpPostedFileBase file)
        {
            if (ModelState.IsValid && CustomValidators.ValidateFile(file))
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath(UrlConstants.UrlPrepender + UrlConstants.AutoImagesFilesDirectory), fileName);
                file.SaveAs(path);

                auto.ImageFileName = fileName;
                db.Autos.Add(auto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ComboBoxPopulator.PopulateAutoComboBoxes(ViewBag);
            }

            return View("../Auto/Create", auto);
        }

        //
        // GET: /Auto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Auto auto = db.Autos.Find(id);
            if (auto == null)
            {
                return HttpNotFound();
            }
            ComboBoxPopulator.PopulateAutoComboBoxes(ViewBag);
            return View("../Auto/Edit", auto);
        }

        //
        // POST: /Auto/Edit/5

        [HttpPost]
        public ActionResult Edit(Auto auto, HttpPostedFileBase file)
        {
            if (ModelState.IsValid && CustomValidators.ValidateFile(file))
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath(UrlConstants.UrlPrepender + UrlConstants.AutoImagesFilesDirectory), fileName);
                file.SaveAs(path);

                db.Entry(auto).State = EntityState.Modified;
                auto.ImageFileName = fileName;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ComboBoxPopulator.PopulateAutoComboBoxes(ViewBag);
            return View("../Auto/Edit", auto);
        }

        //
        // GET: /Auto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Auto auto = db.Autos.Find(id);
            if (auto == null)
            {
                return HttpNotFound();
            }
            return View("../Auto/Delete", auto);
        }

        //
        // POST: /Auto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Auto auto = db.Autos.Find(id);
            db.Autos.Remove(auto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}