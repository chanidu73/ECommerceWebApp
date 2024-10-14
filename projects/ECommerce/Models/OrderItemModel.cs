using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class OrderItemModel
    {
        [Key]
        public int OrderItemId { get;set; }
        public int Quantity { get;set; }
        [ForeignKey("Order")]
        public int OrderId { get;set; }
        public OrderModel? Order { get;set ;}
        [ForeignKey("Product")]
        public int ProductId { get;set; }
        public ProductModel Product { get;set; }
        public decimal Price { get;set; }
        
    }
}