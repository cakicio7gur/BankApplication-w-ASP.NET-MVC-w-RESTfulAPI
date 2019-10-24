using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBankProject.Controllers
{
    public class ParaTransferController : Controller
    {
        // GET: ParaTransfer
        public ActionResult Havale()
        {
            return View();
        }
        public ActionResult VirmanAliciHesap()
        {
            return View();
        }
        public ActionResult HavaleAliciHesap()
        {
            return View();
        }
        public ActionResult HavaleVirmanGonderenHesap()
        {
            return View();
        }
        public ActionResult HavaleVirmanTutar()
        {
            return View();
        }
        public ActionResult HavaleVirmanOnayEkrani()
        {
            return View();
        }
        public ActionResult FaturaOdemeAboneBilgi()
        {
            return View();
        }
        public ActionResult FaturaOdemeFaturaSecimi()
        {
            return View();
        }
        public ActionResult FaturaOdemeHesapSecimi()
        {
            return View();
        }
        public ActionResult FaturaOdemeOnayEkrani()
        {
            return View();
        }
        public ActionResult ParaCekme()
        {
            return View();
        }
        public ActionResult ParaYatirma()
        {
            return View();
        }

    }
}