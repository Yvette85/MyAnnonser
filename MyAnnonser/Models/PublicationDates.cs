using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAnnonser.Models
{
    public class PublicationDates
    {
    
        public int AdId { get; set; }
        public DateTime Date { get; set; }

        public virtual Ads Ads { get; set; }
      
    }
}