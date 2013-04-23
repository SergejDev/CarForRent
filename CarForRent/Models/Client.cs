using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class Client
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public String UserFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public String UserLastName { get; set; }

        [Required]
        [Display(Name = "Midle Name")]
        public String UserMidleName { get; set; }

        [Required]
        [Display(Name = "Passport Number")]
        public String PassportNumber { get; set; }
    }
}