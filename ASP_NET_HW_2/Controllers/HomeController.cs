﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_HW_2.Models;

namespace ASP_NET_HW_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Comment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Comment(Comment comment)
        {

        }
    }
}