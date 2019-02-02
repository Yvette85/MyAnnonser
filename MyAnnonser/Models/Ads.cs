using Dapper;
using MyAnnonser.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyAnnonser.Models
{
    public class Ads
    {
        public Ads(int id  , string adheadline, string adtext , int advertiserId)
        {
            Id = id;
            AdHeadline = adheadline;
            AdText = adtext;
            AdvertiserId = advertiserId;
        }
        public int Id { get; set; }
        public string AdHeadline { get; set; }
        public string AdText { get; set; }
        public int AdvertiserId { get; set; }
    }
    
}
