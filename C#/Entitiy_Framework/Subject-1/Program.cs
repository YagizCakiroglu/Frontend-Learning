using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{     
    public class ShopContext: DbContext
    {        
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                //.UseSqlite("Data Source=shop.db");
                .UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ShopDb;Integrated Security=SSPI;");
                //4.58
        }
    }

    public class Product
    { 
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
            DeleteProduct(5);
        }

        static void DeleteProduct(int id)
        {
            using(var db = new ShopContext())
            {

                var p = new Product(){Id=5};

                // db.Products.Remove(p);
                db.Entry(p).State = EntityState.Deleted;
                db.SaveChanges();

                // var p = db.Products.FirstOrDefault(i=>i.Id==id);

                // if (p!=null)
                // {
                //     db.Products.Remove(p);
                //     db.SaveChanges();

                //     Console.WriteLine("Veri Silindi");
                // }
            }
        }
        static void UpdateProduct()
        {

            using(var db = new ShopContext())
            {
                var p = db.Products.Where(i=>i.Id==1).FirstOrDefault();

                if(p!=null)
                {
                    p.Price = 2400;
                    
                    db.Products.Update(p);
                    db.SaveChanges();
                }
            }

            // using(var db = new ShopContext())
            // {
            //     var entity = new Product(){Id=1};
                
            //     db.Products.Attach(entity);

            //     entity.Price = 3000;

            //     db.SaveChanges();
            // }   



            //   using(var db = new ShopContext())
            //   {
            //       // change tracking
            //       var p = db
            //                 .Products
            //                 //.AsNoTracking()
            //                 .Where(i=>i.Id==1)
            //                 .FirstOrDefault();

            //       if (p!=null)
            //       {
            //             p.Price *= 1.2m;
            //             db.SaveChanges();
            //             Console.WriteLine("güncelleme yapıldı.");

            //       }
            //   }  
        }
        static void GetProductByName(string name)
        {
            using(var context = new ShopContext())
            {
                var products = context
                                .Products
                                .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                                .Select(p => 
                                        new {
                                            p.Name,
                                            p.Price
                                        })
                                .ToList();
             
                foreach (var p in products)
                {
                    Console.WriteLine($"name: {p.Name} price: {p.Price}");
                }
                
            }
        }
        static void GetProductById(int id)
        {
            using(var context = new ShopContext())
            {
                var result = context
                                .Products
                                .Where(p => p.Id == id)
                                .Select(p => 
                                        new {
                                            p.Name,
                                            p.Price
                                        })
                                .FirstOrDefault();
             

                
                Console.WriteLine($"name: {result.Name} price: {result.Price}");
                
            }
        }
        static void GetAllProducts()
        {
            using(var context = new ShopContext())
            {
                var products = context
                .Products
                .Select(p => 
                    new {
                        p.Name,
                        p.Price
                    })
                .ToList();

                foreach (var p in products)
                {
                    Console.WriteLine($"name: {p.Name} price: {p.Price}");
                }
            }
        }
        static void AddProducts()
        {
            using(var db = new ShopContext())
            {
                var products = new List<Product>()
                {
                    new Product { Name = "İphone 11", Price=3000 },
                    new Product { Name = "İphone 12", Price=4000 },
                    new Product { Name = "İphone 13", Price=5000 },
                    new Product { Name = "İphone 14", Price=6000 }
                };          

                db.Products.AddRange(products);                
                db.SaveChanges();

                Console.WriteLine("veriler eklendi.");
            }
        }
        static void AddProduct()
        {
            using(var db = new ShopContext())
            {
                var p = new Product { Name = "İphone 15", Price=8000 }; 

                db.Products.Add(p);                
                db.SaveChanges();

                Console.WriteLine("veriler eklendi.");
            }
        }
   
    }
}
