using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAnnonser.Models
{
    public class Advertisers
    {
        public Advertisers(int id, string advName)
        {
            Id = id;
            AdvName = advName;
        }
        public int Id { get; set; }
        public string AdvName { get; set; }
    }
}