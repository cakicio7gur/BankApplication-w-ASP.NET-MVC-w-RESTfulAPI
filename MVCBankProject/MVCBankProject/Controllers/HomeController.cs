using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBankProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bireysel()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Girisimci()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Kurumsal()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}