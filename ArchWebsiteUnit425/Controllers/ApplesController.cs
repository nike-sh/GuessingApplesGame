using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchWebsiteUnit425.Controllers
{
    public class ApplesController : Controller
    {
        // GET: Apples
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(int NumOfApples)
        {
            return View("Index", NumOfApples);
        }
    }
}