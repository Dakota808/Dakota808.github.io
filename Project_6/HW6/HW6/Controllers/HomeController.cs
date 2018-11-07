using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW6.Models;

namespace HW6.Controllers
{
    public class HomeController : Controller
    {
        private EFUserContext db = new EFUserContext();

        //Get: People/Users
        public ActionResult Index(string Search)
        {
            if (Search == null || Search == "")
            {
                ViewBag.show = false;
                return View();

            }
            else
            {
                ViewBag.show = true;
                return View(db.People.Where(p => p.FullName.ToUpper().Contains(Search.ToUpper())).ToList());
            }
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Details(int id)
        {
            Person person = new Person();
            person = db.People.Find(id);
            return View("Details", person);
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}