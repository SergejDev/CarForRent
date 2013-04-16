using System;
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
        public int Number { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? YearOfManufacture { get; set; }

        [Required]
        public byte PlacesCount { set; get; }

        public double? EngineVolume { set; get; }

        [Required]
        public decimal Price { set; get; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.ImageUrl)]
        public String ImageFileName { set; get; }

        [Required]
        public int AutoCount { set; get; }

        public virtual AutoClass AutoClass { get; set; }

        public virtual EngineType EngineType { get; set; }

        public virtual GearboxType GearboxType { get; set; }

        public virtual FuelType FuelType { get; set; }

    }
}