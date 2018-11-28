using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW8.DAL;


namespace HW8.Controllers
{
    public class HomeController : Controller
    {
        private BidsContext db = new BidsContext();

        public ActionResult Index()
        {

            return View(db.Bids.OrderByDescending(x => x.TimeStamps).Take(10).ToList());
        }

    }
}