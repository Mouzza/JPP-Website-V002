﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JPP.UI.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Jongeren participatie platform";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Jongeren participatie platform";

            return View();
        }

        public ActionResult Diensten()
        {
          

            return View();
        }
    }
}