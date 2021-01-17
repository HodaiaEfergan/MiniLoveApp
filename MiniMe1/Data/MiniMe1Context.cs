using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sharedAngular.Models;

namespace MiniMe1.Data
{
    public class MiniMe1Context : DbContext
    {
        public MiniMe1Context (DbContextOptions<MiniMe1Context> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<ProductsNewOrder>()
                 .HasKey(t => new { t.ProductId, t.NewOrderId });

            modelBuilder.Entity<ProductsNewOrder>()
                .HasOne(pt => pt.Products)
                .WithMany(pt => pt.ProductsNewOrder)
                .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<ProductsNewOrder>()
            .HasOne(pt => pt.NewOrder)
            .WithMany(pt => pt.ProductsNewOrder)
            .HasForeignKey(pt => pt.NewOrderId);



        }




        public DbSet<sharedAngular.Models.Users> Users { get; set; }

        public DbSet<sharedAngular.Models.Products> Products { get; set; }

        public DbSet<sharedAngular.Models.Pay> Pay { get; set; }

        public DbSet<sharedAngular.Models.NewOrder> NewOrder { get; set; }

        public DbSet<sharedAngular.Models.ProductsNewOrder> ProductsNewOrder { get; set; }

        

        

        

        

      

     

     

       
    }
}
