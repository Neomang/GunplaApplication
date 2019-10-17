using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GunplaApplication.Models
{
    public class Gunpla
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ModelNum { get; set; }
        public Gundam Gundam { get; set; }
        public Grade ModelGrade { get; set; } 
        public string Scale { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Gunpla(int id, string name, string modelNum, Grade modelGrade, string scale, DateTime releaseDate)
        {
            ID = id;
            Name = name;
            ModelNum = modelNum;
            ModelGrade = modelGrade;
            Scale = scale;
            ReleaseDate = releaseDate;
        }
    }

    public enum Grade
    {
        PG,
        MG,
        RG,
        HG,
        HGUC,
        HGFC,
        Ungraded
    }
}