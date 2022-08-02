﻿using HaberPortal.Admin.CustomFiter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberPortal.Admin.Controllers
{
    public class HomeController : Controller
    {
        [LoginFilter] //giriş kontrolü.
        public ActionResult Index()
        {
            return View();
        }
    }
}