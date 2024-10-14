using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class OrderModel 
    {
        [Key]
        public int OrderId { get;set; }
        public DateTime OrderDate { get;set ;}
        [ForeignKey("User")]
        public int UserId { get;set; }
        public UserModel User { get;set; }
        public decimal TotalAmount { get;set ;}
        public string Status { get;set; }

    }
}