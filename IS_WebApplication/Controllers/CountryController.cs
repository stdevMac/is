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
    public class CountryController : Controller
    {
        private DB_Infrastructure db = new DB_Infrastructure();
        // GET: Country
        public ActionResult Index()
        {
            return View(db.CountriesTable.ToList());
        }

        // GET: Country/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //kjashdkbasd
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var country = db.CountriesTable.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // GET: Country/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Country/Create
        [HttpPost]
        public ActionResult Create(Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var region = db.RegionsTable.Find(country.Region_ID);
                    if (region == null)
                    {
                        return View(country);
                    }
                    db.CountriesTable.Add(country);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(country);

            }
            catch
            {
                return View(country);
            }
        }

        // GET: Country/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var country = db.CountriesTable.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: Country/Edit/5
        [HttpPost]
        public ActionResult Edit(Country country)
        {
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        var region = db.RegionsTable.Find(country.Region_ID);
                        if (region == null)
                        {
                            return View(country);
                        }
                        db.Entry(country).State = EntityState.Modified;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    return View(country);

                }
                catch
                {
                    return View(country);
                }
            }
        }

        // GET: Country/Delete/5
        public ActionResult Delete(int? id)
        {
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var country = db.CountriesTable.Find(id);
                if (country == null)
                {
                    return HttpNotFound();
                }
                return View(country);
            }
        }

        // POST: Country/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    country = db.CountriesTable.Find(id);
                    if (country == null)
                    {
                        return HttpNotFound();
                    }
                    db.CountriesTable.Remove(country);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(country);

            }
            catch
            {
                return View(country);
            }
        }
    }
}
