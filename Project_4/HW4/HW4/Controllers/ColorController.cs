using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class ColorController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Color_Maker()
        {
            ViewBag.show = false;
            return View();
        }

        [HttpPost]
        public ActionResult Color_Maker(string ColorOne, string ColorTwo)
        {
            //debug print on strings

            //error checking for values of objects

            //convert strings to color objects

            //mix values of color objects w/ err checking

            //make mixed color object with values

            //convert all color objects to html objects
            return View();

        }
    }
}