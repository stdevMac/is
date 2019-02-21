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
    public class StateController : Controller
    {
        private DB_Infrastructure db = new DB_Infrastructure();
        // GET: State
        public ActionResult Index()
        {
            return View(db.StatesTable.ToList());
        }

        // GET: State/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var state = db.StatesTable.Find(id);
            if(state == null)
            {
                return HttpNotFound();
            }
            return View(state);
        }

        // GET: State/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: State/Create
        [HttpPost]
        public ActionResult Create(State state)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.StatesTable.Add(state);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(state);
                
            }
            catch
            {
                return View(state);
            }
        }

        // GET: State/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var state = db.StatesTable.Find(id);
            if (state == null)
            {
                return HttpNotFound();
            }
            return View(state);
        }

        // POST: State/Edit/5
        [HttpPost]
        public ActionResult Edit(State state)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(state).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(state);
                
            }
            catch
            {
                return View(state);
            }
        }

        // GET: State/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var state = db.StatesTable.Find(id);
                if (state == null)
                {
                    return HttpNotFound();
                }
                return View(state);
            }
        }

        // POST: State/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, State state)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    state = db.StatesTable.Find(id);
                    if (state == null)
                    {
                        return HttpNotFound();
                    }
                    db.StatesTable.Remove(state);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(state);
                
            }
            catch
            {
                return View(state);
            }
        }
    }
}
