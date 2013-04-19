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
        
        [Display(Name = "First name")]
        [Required]
        public String UserFirstName { get; set; }

        [Display(Name = "Second name")]
        [Required]
        public String UserSecondName { get; set; }

        [Display(Name = "Midle name")]
        [Required]
        public String UserMidleName { get; set; }

        [Display(Name = "Passport number")]
        [Required]
        public String PassportNumber { get; set; }
    }
}