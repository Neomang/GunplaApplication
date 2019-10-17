using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GunplaApplication.Models
{
    public class Gundam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Pilot> Pilots { get; set; }
        public string ModelNum { get; set; }
        public string Series { get; set; }
        public List<Gunpla> Gunplas { get; set; }

        public Gundam(int id, string name, string modelNum, string series)
        {
            ID = id;
            Name = name;
            ModelNum = modelNum;
            Series = series;
        }
    }
}