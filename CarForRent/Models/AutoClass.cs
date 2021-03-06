﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class AutoClass
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AutoClassId { set; get; }

        [Required]
        [Display(Name = "Класс")]
        public String ClassTitle { set; get; }

    }
}