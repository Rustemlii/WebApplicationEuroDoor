using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.AppContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Detallar> Detallars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<DemoOrder> DemoOrders { get; set; }
        public DbSet<DemoOrderDetail> DemoOrderDetails { get; set; }
       
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
       {

       }
    
    }
}
