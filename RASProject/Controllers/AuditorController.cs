using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RASProject.Controllers
{
    public class AuditorController : Controller
    {
        // GET: Auditor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AuditorProfile()
        {
            return View();
        }
    }
}