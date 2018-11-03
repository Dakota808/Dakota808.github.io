using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5.Models;
using HW5.DAL;
using System.Net;

namespace HW5.Controllers
{
    public class HomeController : Controller
    {
        private RequestContext db = new RequestContext();
        
        //GET Request.cs from models
        public ActionResult Index()
        {
            return View();
        }
         

        public ActionResult Request()
        {
            ViewBag.Message = "Apartment Application";
            return View(db.Requests.ToList());
        }

        public ActionResult Forms(Request Forms)
        {
            ViewBag.Message = "Requests Forms";

            return View();
        }
    }


}