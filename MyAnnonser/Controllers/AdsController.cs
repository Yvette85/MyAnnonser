using Dapper;
using MyAnnonser.Models;
using MyAnnonser.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAnnonser.Controllers
{
    public class AdsController : Controller
    {
        // GET: Ads
        public ActionResult GetAds()
        {
            AdsRepository ad = new AdsRepository();

            return View(ad.GetAllAds());

        }
    }
}

        
    