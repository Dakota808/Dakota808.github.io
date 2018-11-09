using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW6.Models;
using HW6.Models.ViewModels;
using System.Net;

namespace HW6.Controllers
{
    public class HomeController : Controller
    {
        private EFUserContext db = new EFUserContext();

        //Get: People/Users
        public ActionResult Index(string Search)
        {
            WWModelView vm = new WWModelView();
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

        public ActionResult Details(int? id)
        {
            WWModelView vm = new WWModelView
            {
                MyPerson = db.People.Find(id)
            };
            ViewBag.IsP = false;

            if (vm.MyPerson.Customers2.Count() > 0)
            {
                ViewBag.IsP = true;
                int customerID = vm.MyPerson.Customers2.FirstOrDefault().CustomerID;
                vm.MyCustomer = db.Customers.Find(customerID);

                //Sums the Gross sales
                ViewBag.GrossSales = vm.MyCustomer.Orders.SelectMany(s => s.Invoices).SelectMany(p => p.InvoiceLines).Sum(x => x.ExtendedPrice);

                ViewBag.GrossProfit = vm.MyCustomer.Orders.SelectMany(s => s.Invoices).SelectMany(p => p.InvoiceLines).Sum(x => x.LineProfit);

                vm.MyInvoiceLine = vm.MyCustomer.Orders.SelectMany(y => y.Invoices)
                                                                   .SelectMany(z => z.InvoiceLines)
                                                                   .OrderByDescending(v => v.LineProfit)
                                                                   .Take(10)
                                                                   .ToList();

            }

            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person myPerson = db.People.Find(id);
            if(myPerson == null)
            {
                return HttpNotFound();
            }
            return View("Details", vm);
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}