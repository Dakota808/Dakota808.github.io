using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8.DAL;
using HW8.Models;

namespace HW8.Controllers
{
    public class BidsController : Controller
    {
        private BidContext db = new BidContext();


        // GET: Bids/Create
        public ActionResult Create()
        {
            ViewBag.Bider = new SelectList(db.Buyers, "BuyerID", "BuyersName");
            ViewBag.Item = new SelectList(db.Items, "ItemID", "ItemName");
            return View();
        }

        // POST: Bids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BidID,Item,Bider,TimeStamps,Prices")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Index", "Items");
            }

            ViewBag.Bider = new SelectList(db.Buyers, "BuyerID", "BuyersName", bid.Bider);
            ViewBag.Item = new SelectList(db.Items, "ItemID", "ItemName", bid.Item);
            return View(bid);
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
