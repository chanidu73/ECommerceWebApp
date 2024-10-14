using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get;set; }
        public string Name { get;set; }
        public string Description { get;set; }
        public decimal Price { get;set ;}
        public int StockQuantity { get;set; }
        [ForeignKey("Category")]
        public int CategoryId { get;set ;}
        public CategoryModel Category { get;set; }
        public DateTime CreatedDate { get;set; }

    }
}