using ArchWebsiteUnit425.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchWebsiteUnit425.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int NumOfApples)
        {
            if (NumOfApples != 7)
            {
                ViewBag.title = "Try Again";
                ViewBag.Message = "Incorrect guess";
                return Index();
            }
            else
            {
                return RedirectToAction("Index", "Apples", NumOfApples);
            }
        }

        public ActionResult Apples()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }
    }
}