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
            modelBuilder.Entity<ProductsOrder>()
                 .HasKey(t => new { t.ProductId, t.OrdertId });

            modelBuilder.Entity<ProductsOrder>()
                .HasOne(pt => pt.Products)
                .WithMany(pt => pt.ProductsOrder)
                .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<ProductsOrder>()
            .HasOne(pt => pt.Order)
            .WithMany(pt => pt.ProductsOrder)
            .HasForeignKey(pt => pt.OrdertId);



        }




        public DbSet<sharedAngular.Models.Users> Users { get; set; }

        public DbSet<sharedAngular.Models.Products> Products { get; set; }

        public DbSet<sharedAngular.Models.Pay> Pay { get; set; }

        public DbSet<sharedAngular.Models.Order> Order { get; set; }

        public DbSet<sharedAngular.Models.ProductsOrder> ProductsOrder { get; set; }

        

        

      

     

     

       
    }
}
