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
        public String UserFirstName { get; set; }

        [Required]
        public String UserSecondName { get; set; }

        [Required]
        public String UserMidleName { get; set; }

        [Required]
        public String PassportNumber { get; set; }
    }
}