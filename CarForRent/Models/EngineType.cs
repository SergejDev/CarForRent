using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class EngineType
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int EngineTypeId { set; get; }

        [Required]
        public String EngineTypeTitle { set; get; }

    }
}