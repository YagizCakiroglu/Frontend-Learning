using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;


namespace ConsoleApp
{
    public class ShopContext: DbContext
    {
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;}

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => {builder.AddConsole(); });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .UseSqlite("Data Source=shop.db");
        }
    }

    public class Product
    {
        //primary key(Id, <table_name>Id)
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            AddProduct();
        }

        static void AddProducts()
        {
            using (var db = new ShopContext())
            {
                var products = new List<Product>()
                {
                    new Product { Name = "İphone 11", Price=2000},
                    new Product { Name = "İphone 12", Price=3000},
                    new Product { Name = "İphone 13", Price=4000},
                    new Product { Name = "İphone 14", Price=5000}
                };

                db.Products.AddRange(products);
                db.SaveChanges();

                Console.WriteLine("Veriler Eklendi");
            }
        }

        static void AddProduct()
        {
            using (var db = new ShopContext())
            {
                var p = new Product { Name = "İphone 15", Price=8000};
                

                db.Products.Add(p);
                db.SaveChanges();

                Console.WriteLine("Veriler Eklendi");
            }
        }

    }
}