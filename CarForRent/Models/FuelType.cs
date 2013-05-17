using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class FuelType
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int FuelTypeId { set; get; }

        [Required]
        [Display(Name = "Тип топлива")]
        public String FuelTypeTitle { set; get; }

    }
}