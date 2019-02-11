using Dapper;
using MyAnnonser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAnnonser.Models
{
    public class Ads
    {
        

       
        [Display(Name="Id")]
        public int AdId { get; set; }

        [Required(ErrorMessage ="HeadLine is required")]
        public string AdHeadline { get; set; }

        [Required(ErrorMessage ="Text is required")]
        public string AdText { get; set; }

        public int AdvertiserId { get; set; }

        public Advertisers Advertisers { get; set; }
        public string AdName { get;  set; }


        public IEnumerable<SelectListItem> ListAdvertisers { get; set; }



    }
    
}
