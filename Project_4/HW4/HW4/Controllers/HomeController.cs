using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Converter()
        {
            ViewBag.Message = "Miles to Metric Converter";

            return View();
        }

        public ActionResult Color_Maker()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Result()
        {
            {
                Debug.WriteLine(Request.QueryString["Input"]);

                string name = Request.QueryString["user_name"];

                return View();
            }
        }
    }
}