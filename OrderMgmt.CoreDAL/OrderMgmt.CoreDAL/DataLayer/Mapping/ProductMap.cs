using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Order.CoreDAL.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Order.CoreDAL.DataLayer.Mapping
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> options)
        {
            options.HasKey(t => t.ProductId);
            options.Property(t => t.ProductId).ValueGeneratedOnAdd();
            options.Property(t => t.ProductName).IsRequired().HasMaxLength(512);
            options.Property(t => t.ProductCode).IsRequired().HasMaxLength(5);
            options.Property(t => t.UnitPrice).IsRequired();

        }

    }
}
