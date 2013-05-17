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

        [Display(Name = "Количество суток")]
        [Range(1, int.MaxValue, ErrorMessage = "Минимальное количество суток - 1 сутки")]
        public int OrderDuration { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Дата заказа")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "Текущее состояние")]
        public bool IsOpen { get; set; }


        public int AutoId { get; set; }

        [ForeignKey("AutoId")]
        [Display(Name = "Автомобиль")]
        public virtual Auto Auto { get; set; }


        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual UserProfile Client { get; set; }
    }
}