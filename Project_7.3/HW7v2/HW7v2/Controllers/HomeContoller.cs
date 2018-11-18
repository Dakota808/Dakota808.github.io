using System;
using System.Collections.Generic;
using System.Web;
using System.Dynamic;
using System.Web.Mvc;

namespace HW7v2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Main page
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}