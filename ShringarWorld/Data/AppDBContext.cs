using Microsoft.EntityFrameworkCore;
using ShringarWorld.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;


namespace ShringarWorld.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base (options)
        { 
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Earings>().HasKey(am => new
        //    {
        //        am.Id
        //    });
        //    base.OnModelCreating(modelBuilder);
        //}

       // public DbSet<Earings> Earings { get; set; }
        //public DbSet<Necklace> Necklaces { get; set; }

        //Orders related tables
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}
