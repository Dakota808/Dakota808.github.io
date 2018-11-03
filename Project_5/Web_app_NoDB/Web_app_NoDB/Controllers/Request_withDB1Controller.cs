using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_app_NoDB.DAL;
using Web_app_NoDB.Models;

namespace Web_app_NoDB.Controllers
{
    public class Request_withDB1Controller : Controller
    {
        private RequestContext db = new RequestContext();

        // GET: Request_withDB1
        public ActionResult Index()
        {
            return View(db.submittedForms.ToList());
        }

        // GET: Request_withDB1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request_withDB request_withDB = db.submittedForms.Find(id);
            if (request_withDB == null)
            {
                return HttpNotFound();
            }
            return View(request_withDB);
        }

        // GET: Request_withDB1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Request_withDB1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,phoneNumber,apartmentName,apartmentUnit,Request,RequestSubmitted,submitRequest")] Request_withDB request_withDB)
        {
            if (ModelState.IsValid)
            {
                db.submittedForms.Add(request_withDB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(request_withDB);
        }

        // GET: Request_withDB1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request_withDB request_withDB = db.submittedForms.Find(id);
            if (request_withDB == null)
            {
                return HttpNotFound();
            }
            return View(request_withDB);
        }

        // POST: Request_withDB1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,phoneNumber,apartmentName,apartmentUnit,Request,RequestSubmitted,submitRequest")] Request_withDB request_withDB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(request_withDB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(request_withDB);
        }

        // GET: Request_withDB1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request_withDB request_withDB = db.submittedForms.Find(id);
            if (request_withDB == null)
            {
                return HttpNotFound();
            }
            return View(request_withDB);
        }

        // POST: Request_withDB1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Request_withDB request_withDB = db.submittedForms.Find(id);
            db.submittedForms.Remove(request_withDB);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
