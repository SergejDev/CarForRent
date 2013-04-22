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

        [Display(Name = "Mark auto")]
        [Required]
        public String Mark { get; set; }

        [Display(Name = "Model auto")]
        [Required]
        public String Model { get; set; }

        [Display(Name = "Number auto")]
        [Required]
        public int Number { get; set; }

        [Display(Name = "Year of manufacture")]
        [DataType(DataType.DateTime)]
        public DateTime? YearOfManufacture { get; set; }

        [Display(Name = "Places count")]
        [Required]
        public byte PlacesCount { set; get; }

        [Display(Name = "Engine volume")]
        public double? EngineVolume { set; get; }

        [Display(Name = "Price")]
        [Required]
        public decimal Price { set; get; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.ImageUrl)]
        [Display(Name = "Image")]
        public String ImageFileName { set; get; }

        [Display(Name = "Auto counts")]
        [Required]
        public int AutoCount { set; get; }

        public virtual AutoClass AutoClass { get; set; }

        public virtual EngineType EngineType { get; set; }

        public virtual GearboxType GearboxType { get; set; }

        public virtual FuelType FuelType { get; set; }

    }
}