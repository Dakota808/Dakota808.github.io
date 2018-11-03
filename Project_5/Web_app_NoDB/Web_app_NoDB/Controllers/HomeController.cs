using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_app_NoDB.Models;

namespace Web_app_NoDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Requests()
        {
            ViewBag.Message = "Apartment Application";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Request_withDB requestReport)
        {
            ViewBag.Message = "Requests Forms";

            return View();
        }
    }
}