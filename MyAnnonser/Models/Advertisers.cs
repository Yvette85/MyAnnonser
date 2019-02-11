using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAnnonser.Models
{
    public class Advertisers
    {
        

        public int AdvertiserId { get; set; }
        public string AdName { get; set; }
        //public virtual Ads Ads{ get; set; }

        public virtual ICollection <Ads> Ads { get; set; }

       
    }
}