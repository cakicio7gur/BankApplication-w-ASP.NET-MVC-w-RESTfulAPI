using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ModelLayer.DTOs;
using ModelLayer.Models;

namespace MVCBankProject.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Hesap(int musteriNo)
        {
            IEnumerable<ModelLayer.DTOs.HesapDTO> hesaplar = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63237/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Hesap/GetByMusteriNo?musteriNo=100001");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ModelLayer.DTOs.HesapDTO>>();
                    readTask.Wait();

                    hesaplar = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    hesaplar = Enumerable.Empty<ModelLayer.DTOs.HesapDTO>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(hesaplar);
        }
        public ActionResult HesapDetay()
        {
            return View();
        }
        public ActionResult Profil()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        public ActionResult Menu(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63237/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Hesap/GetToplamBakiye/"+id.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<String>();
                    readTask.Wait();
                    ViewBag.toplamBakiye = readTask.Result;
                }
            }
            return View();
        }

    }
}