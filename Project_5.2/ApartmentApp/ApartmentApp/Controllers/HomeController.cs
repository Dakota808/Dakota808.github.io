using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApartmentApp.Models;
using ApartmentApp.DAL;

namespace ApartmentApp.Controllers
{
    public class HomeController : Controller
    {
        private RequestContext db = new RequestContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Requested()
        {
            ViewBag.Message = "Apartment Requests";

            return View(db.Requests.ToList());
        }
        [HttpGet]
        public ActionResult Form()
        {
            ViewBag.Message = "Work order Requests";
            return View();
        }


        [HttpPost]
        public ActionResult Form([Bind(Include = "ID,FirstName,LastName,PhoneNumber,ApartmentName,Unit,RequestReport,RequestTime,SubmitRequest")] Request requestForm)
        {
            if (ModelState.IsValid)
            {
                db.Requests.Add(requestForm);
                db.SaveChanges();
                return RedirectToAction("Requested");
            }
            return View(requestForm);
        }


    }
}