using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RASProject.Controllers
{
    public class BranchManagerController : Controller
    {
        // GET: BranchManager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BranchManagerProfile()
        {
            return View();
        }
    }
}