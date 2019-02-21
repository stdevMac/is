using Domain;
using IS_WebApplication.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IS_WebApplication.Controllers
{
    public class RegionController : Controller
    {
        private DB_Infrastructure db = new DB_Infrastructure();
        // GET: Region
        public ActionResult Index()
        {
            return View(db.RegionsTable.ToList());
        }

        // GET: Region/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var region = db.RegionsTable.Find(id);
            if (region== null)
            {
                return HttpNotFound();
            }
            return View(region);
        }

        // GET: Region/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Region/Create
        [HttpPost]
        public ActionResult Create(Region region)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.RegionsTable.Add(region);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(region);

            }
            catch
            {
                return View(region);
            }
        }

        // GET: Region/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var region = db.RegionsTable.Find(id);
            if (region == null)
            {
                return HttpNotFound();
            }
            return View(region);
        }

        // POST: Region/Edit/5
        [HttpPost]
        public ActionResult Edit( Region region)
        {

            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        db.Entry(region).State = EntityState.Modified;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    return View(region);

                }
                catch
                {
                    return View(region);
                }
            }
        }

        // GET: Region/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var region = db.RegionsTable.Find(id);
                if (region == null)
                {
                    return HttpNotFound();
                }
                return View(region);
            }
        }

        // POST: Region/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Region region)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    region = db.RegionsTable.Find(id);
                    if (region == null)
                    {
                        return HttpNotFound();
                    }
                    db.RegionsTable.Remove(region);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(region);

            }
            catch
            {
                return View(region);
            }
        }
    }
}
