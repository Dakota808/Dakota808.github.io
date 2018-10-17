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

        [HttpGet]
        public ActionResult Converter()
        {
            ViewBag.Message = "Miles to Metric Converter";
            double miles = Convert.ToDouble(Request.QueryString["mile"]);
            string mearsurement = Request.QueryString["metric-unit"];
            Debug.WriteLine(miles);
            Debug.WriteLine(mearsurement);

            double result;
            switch (mearsurement)
            {
                case "millimeters":
                    result = miles * 1609344;
                    break;
                case "centimeters":
                    result = miles * 160934.4;
                    break;
                case "meters":
                    result = miles * 1609.344;
                    break;
                case "kilometers":
                    result = miles * 1.609344;
                    break;
                default:
                    result = -1;
                    break;
            }

            ViewBag.Message();

            return View();
        }

        public ActionResult Color_Maker()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      
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