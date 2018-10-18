using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Color_Maker()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}