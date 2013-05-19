using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class SearchingFilter
    {

        public String Mark { get; set; }

        public String Model { get; set; }
        
        public String YearOfManufacture { get; set; }

        public String PlacesCount { set; get; }

        public String EngineVolume { set; get; }

        public String Price { set; get; }

        public String AutoClass { get; set; }

        public String EngineType { get; set; }

        public String GearboxType { get; set; }

        public String FuelType { get; set; }
    }
}