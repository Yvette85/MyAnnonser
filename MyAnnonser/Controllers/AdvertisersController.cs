using MyAnnonser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAnnonser.Controllers
{
    public class AdvertisersController : Controller
    {
        // GET: Advertisers
        public ActionResult Index()
        {
            AdsRepository adrepo = new AdsRepository();


            return View(adrepo.GetAllAdvert());
            
        }
    }
}