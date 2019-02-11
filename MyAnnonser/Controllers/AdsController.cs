using Dapper;
using MyAnnonser.Models;
using MyAnnonser.Repository;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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




        // GET: Ads/Create
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Create(Ads ad)
        {
            try
            {

                if (ModelState.IsValid)
                {



                    AdsRepository adrepo = new AdsRepository();

                    adrepo.AddAnns(ad);

                    var advertisers = adrepo.GetAllAdvert();


                    ad.ListAdvertisers = advertisers.Select(x => new SelectListItem()
                    {
                        Text = x.AdName,
                        Value = x.AdvertiserId.ToString()
                    });
                   
                }

                return View();
            }
            catch
            {
                return View();
            }
        }




        //GET: Adano/Edit/5
        public ActionResult Edit(int id)
        {
            AdsRepository adrepo = new AdsRepository();
            return View(adrepo.GetAllAds().Find(ads => ads.AdId == id));
        }



       
            //POST: Adano/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ads ads)
        {
            try
            {
                AdsRepository adrepo = new AdsRepository();
                adrepo.UpdateAnnons(ads);


                return RedirectToAction("GetAllAds");
            }
            catch
            {
                return View();
            }


        }
      


        //POST: Adano/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                AdsRepository adrepo = new AdsRepository();

                if (adrepo.DeleteAnnons(id))
                {
                    ViewBag.alertMsg = "Annsons details deleted successfully";
                }

                // TODO: Add delete logic here

                return RedirectToAction("GetAllAds");
            }
            catch
            {
                return RedirectToAction("GetAllAds");
            }
        }
    }
}




