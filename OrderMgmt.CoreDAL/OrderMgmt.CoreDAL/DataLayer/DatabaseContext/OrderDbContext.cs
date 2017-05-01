using Microsoft.EntityFrameworkCore;
using Order.CoreDAL.DataLayer.Mapping;
using Order.CoreDAL.EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.CoreDAL.DataLayer.DatabaseContext
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductMap(modelBuilder.Entity<Product>());
        }
    }
}
