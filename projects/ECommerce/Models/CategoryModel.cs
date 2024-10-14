using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class CategoryModel
    {
        [Key]
        public int CaategoryId { get;set; }
        public string Name { get;set; }
        public string Description { get;set; }
    }
}