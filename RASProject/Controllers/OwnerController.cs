﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RASProject.Controllers
{
    public class OwnerController : Controller
    {
        // GET: Owner
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OwnerProfile()
        {
            return View();
        }
    }
}