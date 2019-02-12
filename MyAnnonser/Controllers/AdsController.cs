using MyAnnonser.Models;
using MyAnnonser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAnnonser.Controllers
{
    public class AdsController : Controller
    {
        // GET: Ads
        public ActionResult Index()
        {
            AdsRepository adrepo = new AdsRepository();
            return View(adrepo.GetAllAds());
        }

        //// GET: Ads/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Ads/Create
        public ActionResult Create()
        {

            AdsRepository adrepo = new AdsRepository();
            var advertisers = adrepo.GetAllAdvert();
            Ads ad = new Ads();
        
            ad.ListAdvertisers = advertisers.Select(x => new SelectListItem()
            {
                Text = x.AdName,
                Value = x.AdvertiserId.ToString(),
            });

            return View();
        }

        // POST: Ads/Create
        [HttpPost]
        public ActionResult Create(Ads ad)
        {
            try
            {
                if (ModelState.IsValid)
                {

                
                AdsRepository adrepo = new AdsRepository();
                adrepo.AddAnns(ad);
                ViewBag.Message = "Records added successfully";
            }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Ads/Edit/5
        public ActionResult Edit(int id)
        {
            AdsRepository adrepo = new AdsRepository();
            return View(adrepo.GetAllAds().Find(ad => ad.AdId==id));
        }

        // POST: Ads/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ads ad)
        {
            try
            {
                AdsRepository adrepo = new AdsRepository();
                adrepo.UpdateAnnons(ad);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ads/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Ads/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                AdsRepository adrepo = new AdsRepository();
                if (adrepo.DeleteAnnons(id))
                {
                    ViewBag.AlertMsg = "Annons deleted";
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
