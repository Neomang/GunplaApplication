using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GunplaApplication.Models
{
    public class Pilot
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Gundam> Gundams { get; set; }
        public List<string> Series { get; set; }
        public string Timeline { get; set; }

        public Pilot(int id, string name, List<string> series, string timeline)
        {
            ID = id;
            Name = name;
            Series = series;
            Timeline = timeline;
        }
    }
}