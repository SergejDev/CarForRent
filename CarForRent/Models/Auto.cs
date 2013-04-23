﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class Auto
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AutoId { get; set; }

        [Required]
        public String Mark { get; set; }

        [Required]
        public String Model { get; set; }

        [Required]
        public String Number { get; set; }

        [Display(Name="Year Of Manufacture")]
        public int? YearOfManufacture { get; set; }

        [Required]
        [Display(Name = "Places Count")]
        public byte PlacesCount { set; get; }

        [Display(Name = "Engine Volume")]
        public float EngineVolume { set; get; }

        [Required]
        public decimal Price { set; get; }   

        [DataType(System.ComponentModel.DataAnnotations.DataType.ImageUrl)]
        public String ImageFileName { set; get; }

        [Required]
        [Display(Name = "Auto Count")]
        public int AutoCount { set; get; }

        public virtual AutoClass AutoClass { get; set; }

        [Display(Name = "Engine Type")]
        public virtual EngineType EngineType { get; set; }

        [Display(Name = "Gearbox Type")]
        public virtual GearboxType GearboxType { get; set; }

        [Display(Name = "Fuel Type")]
        public virtual FuelType FuelType { get; set; }

    }
}