using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class OrderContext : DbContext
    {
        public OrderContext()
        {
        }

        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Personal> Personals { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=OrderTestDB;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personal>()
                .HasData(
                 new Personal()
                 {
                     Id=1,
                     Name = "غیاثوند",
                     CompanyName ="تست یک",
                     Email = " saj@saj.com",
                     Phone = " 0930",
                 },
                 new Personal()
                 {
                     Id= 2,
                     Name = "جعفری",
                     CompanyName ="تست دو",
                     Email = " j@j.com",
                     Phone = " 0939",
                 },
                 new Personal()
                 {
                     Id = 3,
                     Name = "چگونیان",
                     CompanyName ="تست سه",
                     Email = " ch@ch.com",
                     Phone = " 0912",
                 }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product()
                    {
                        Id=1,
                        Name = "محصول یک",
                        Code = 001,
                        Price = 320000,
                    },
                    new Product()
                    {
                        Id=2,
                        Name = "محصول دو",
                        Code = 005,
                        Price = 920000,
                    },
                   new Product()
                   {
                       Id=3,
                       Name = "محصول سه",
                       Code = 006,
                       Price = 4700000,
                   }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
