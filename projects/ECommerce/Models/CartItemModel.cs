using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class CartItemModel
    {
        [Key]
        public int CartItemId { get;set; }
        public int Quantity { get;set; }
        [ForeignKey("Cart")]
        public int CartId { get;set; }
        public CartModel Cart { get;set; }
        
    }
}