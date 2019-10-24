using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Net;

namespace MVCBankProject.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string tckn,string sifre)
        {
            return View();
        }
    }
}