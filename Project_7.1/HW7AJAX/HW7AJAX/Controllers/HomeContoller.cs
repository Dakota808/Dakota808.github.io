using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HW7AJAX.Controllers
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