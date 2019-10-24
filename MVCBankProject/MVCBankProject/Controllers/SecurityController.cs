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
            /*HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:63237/api/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-ww-from-urlencoded"));

            var postData = new Dictionary<string, string>();
            postData.Add("grant_type", "sifre");
            postData.Add("username", tckn);
            postData.Add("sifre", sifre);
            HttpContent content = new FormUrlEncodedContent(postData);
            HttpResponseMessage response = client.PostAsync("token", content).Result;

            if (response.IsSuccessStatusCode)
            {
                Token token = response.Content.ReadAsAsync<Token>().Result;
                Session["token"] = token.access_token;
            }
            else
            {
                return View();
            }*/
            return RedirectToAction("Menu", "Musteri");
        }
    }
}