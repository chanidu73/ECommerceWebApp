using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class CartModel
    {
        [Key]
        public int CartId { get;set; }
        public DateTime CreatedDate { get;set; }
        [ForeignKey("User")]
        public int UserId { get;set; }
        public UserModel User { get;set; }
    }
}