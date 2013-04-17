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

        public int OrderDuration { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [Required]
        public bool IsOpen { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }

        public virtual ICollection<UserProfile> Clients { get; set; }
    }
}