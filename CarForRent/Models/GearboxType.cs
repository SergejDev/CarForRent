﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class GearboxType
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int GearboxTypeId { set; get; }

        [Required]
        [Display(Name = "Тип коробки передач")]
        public String GearboxTypeTitle { set; get; }

    }
}