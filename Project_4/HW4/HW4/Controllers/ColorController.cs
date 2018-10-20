using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.Mvc;
using System.Diagnostics;

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
            ColorOne = Request.Form["Color1"];
            ColorTwo = Request.Form["Color2"];
            Debug.WriteLine(ColorOne);
            Debug.WriteLine(ColorTwo);
            //error checking for values of objects
            int color_A;
            int color_R;
            int color_B;
            int color_G;
            //convert strings to color objects
            Color rgb_c1 = ColorTranslator.FromHtml(ColorOne);
            Color rgb_c2 = ColorTranslator.FromHtml(ColorTwo);

            //mix values of color objects w/ err checking
            
            //This is for the bits of the hexadecimal which is color A

            if (rgb_c1.A + rgb_c2.A >= 255)
            {
                color_A = 255;
            }
            else
            {
                color_A = rgb_c1.A + rgb_c2.A;
            }

            if (rgb_c1.R + rgb_c2.R >= 255)
            {
                color_R = 255;
            }
            else
            {
                color_R = rgb_c1.R + rgb_c2.R;
            }

            if (rgb_c1.B + rgb_c2.B >= 255)
            {
                color_B = 255;
            }
            else
            {
                color_B = rgb_c1.B + rgb_c2.B;
            }

            if (rgb_c1.G + rgb_c2.G >= 255)
            {
                color_G = 255;
            }
            else
            {
                color_G = rgb_c1.G + rgb_c2.G;
            }



            //make mixed color object with values
            string mixColor = ColorTranslator.ToHtml(Color.FromArgb(color_A, color_R, color_B, color_G));
            //convert all color objects to html objects
            if( ColorOne != null && ColorTwo != null)
            {
                ViewBag.show = true;



            }


            return View();

        }
    }
}