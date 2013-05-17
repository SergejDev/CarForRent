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
        [Display(Name = "Марка")]
        public String Mark { get; set; }

        [Required]
        [Display(Name = "Модель")]
        public String Model { get; set; }

        [Required]
        [Display(Name = "Номера автомобиля")]
        public String Number { get; set; }

        [Display(Name="Год выпуска")]
        public int? YearOfManufacture { get; set; }

        [Required]
        [Display(Name = "Количество мест")]
        public byte PlacesCount { set; get; }

        [Display(Name = "Объем двигателя")]
        public float EngineVolume { set; get; }

        [Required]
        [Display(Name = "Цена дол.$/сутки")]
        public decimal Price { set; get; }   

        [DataType(System.ComponentModel.DataAnnotations.DataType.ImageUrl)]
        public String ImageFileName { set; get; }

        [Required]
        [Display(Name = "Количество автомобилей")]
        public int AutoCount { set; get; }


        public int AutoClassId { set; get; }

        [Display(Name = "Класс автомобиля")]
        [ForeignKey("AutoClassId")]
        public virtual AutoClass AutoClass { get; set; }


        public int EngineTypeId { set; get; }

        [Display(Name = "Тип двигателя")]
        [ForeignKey("EngineTypeId")]
        public virtual EngineType EngineType { get; set; }


        public int GearboxTypeId { set; get; }

        [Display(Name = "Коробка передач")]
        [ForeignKey("GearboxTypeId")]
        public virtual GearboxType GearboxType { get; set; }


        public int FuelTypeId { set; get; }

        [Display(Name = "Тип топлива")]
        [ForeignKey("FuelTypeId")]
        public virtual FuelType FuelType { get; set; }

    }
}