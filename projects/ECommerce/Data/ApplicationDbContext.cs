using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        } 
        public DbSet<CartItemModel>CartItems { get;set; }
        public DbSet<CartModel> Carts { get;set; }
        public DbSet<CategoryModel> Categories { get;set; }
        public DbSet<OrderItemModel> OrderItems { get;set; }
        public DbSet<OrderModel>Orders { get;set; }
        public DbSet<PaymentModel>Payments  { get;set; }
        public DbSet<ProductModel>Products  {get;set ;}
        public DbSet<UserModel>Users { get;set; }
    }
}