﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4ApplicationFx40WithLib.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var c = new ClassLibrary1.Class1();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application. " + c.Foo;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
