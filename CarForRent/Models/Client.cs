using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class Client//not used
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Display(Name = "First Name")]
        public String UserFirstName { get; set; }

        [Display(Name = "Last Name")]
        public String UserLastName { get; set; }

        [Display(Name = "Midle Name")]
        public String UserMidleName { get; set; }

        [Display(Name = "Passport Number")]
        public String PassportNumber { get; set; }
    }
}