﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace HW7.Controllers
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