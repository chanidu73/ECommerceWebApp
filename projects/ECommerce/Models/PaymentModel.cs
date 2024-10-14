using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class PaymentModel
    {
        [Key]
        public int PaymentId { get;set; }
        public DateTime OrderDate { get;set; }
        [ForeignKey("Order")]
        public int OrderId { get;set; }
        public OrderModel Order { get;set; }
        public decimal Amount { get;set; }
        public string PaymentMethod { get;set; }
        public string Status { get;set;}
    }
}