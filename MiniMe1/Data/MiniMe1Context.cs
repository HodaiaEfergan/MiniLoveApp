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

        public DbSet<sharedAngular.Models.Users> Users { get; set; }

        public DbSet<sharedAngular.Models.Products> Products { get; set; }

        public DbSet<sharedAngular.Models.Pay> Pay { get; set; }

        public DbSet<sharedAngular.Models.Orders> Orders { get; set; }

        public DbSet<sharedAngular.Models.OrderProducts> OrderProducts { get; set; }

      

     

     

       
    }
}
