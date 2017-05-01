using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Order.CoreDAL.DataLayer.DatabaseContext;

namespace Order.CoreDAL.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20170430114354_productMigration")]
    partial class productMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Order.CoreDAL.EntityLayer.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.Property<double>("UnitPrice");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });
        }
    }
}
