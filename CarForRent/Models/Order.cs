using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class Order
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Display(Name = "Order duration")]
        public int OrderDuration { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Order date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "Current")]
        public bool IsOpen { get; set; }


        public int AutoId { get; set; }

        [ForeignKey("AutoId")]
        [Display(Name = "Auto")]
        public virtual Auto Auto { get; set; }


        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual UserProfile Client { get; set; }
    }
}