using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAnnonser.Models
{
    public class PublicationDates
    {
    
     
        public DateTime Date { get; set; }

        public  Ads Ads { get; set; }
        public int AdId { get; set; }

    }
}