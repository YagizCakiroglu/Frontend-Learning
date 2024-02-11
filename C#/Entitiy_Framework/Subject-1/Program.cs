using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{     
    public class ShopContext: DbContext
    {        
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .UseSqlite("Data Source=shop.db");
                //.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ShopDb;Integrated Security=SSPI;");
                //.UseMySql(@"server=localhost;port=3306;database=ShopDb;user=root;password=password;");                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasIndex(u=>u.Username)
                        .IsUnique();

            modelBuilder.Entity<Product>()
                        .ToTable("Urunler");

            modelBuilder.Entity<Customer>()
                        .Property(p=>p.IdentityNumber)
                        .HasMaxLength(11)
                        .IsRequired();

            modelBuilder.Entity<ProductCategory>()
                        .HasKey(t => new { t.ProductId, t.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                        .HasOne(pc => pc.Product)
                        .WithMany(p => p.ProductCategories)
                        .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                        .HasOne(pc => pc.Category)
                        .WithMany(c => c.ProductCategories)
                        .HasForeignKey(pc => pc.CategoryId);
        }
    }

    // One to Many
    // One to One
    // Many to Many

    // convention
    // data annotations
    // fluent api

    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(8),MaxLength(15)]
        public string Username { get; set; }
        [Column(TypeName="varchar(20)")]
        public string Email { get; set; }

        public Customer Customer { get; set; }
        public List<Address> Addresses { get; set; }
    }

    public class Customer 
    {
        [Column("customer_id")]
        public int Id { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }
    public class Address
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public User User { get; set; } // navigation property
        public int UserId { get; set; } // int=> null, 1, 2, 3, 4
    }
   public class Product
{ 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime InsertedDate { get; set; } = DateTime.Now;

    public DateTime? LastUpdatedDate { get; set; } // Nullable DateTime

    public List<ProductCategory> ProductCategories { get; set; }
}





    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
    // [NotMapped]
    [Table("UrunKategorileri")]
    public class ProductCategory 
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

    // public class Order
    // {
    //     public int Id { get; set; }
    //     public int ProductId { get; set; }
    //     public DateTime DateAdded { get; set; }
    // }
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ShopContext())
            {
                // var p = new Product()
                // {
                //     Name = "Samsung S6",
                //     Price = 2000
                // };

                var p = db.Products.FirstOrDefault();

                p.Name="Samsung S12";
                db.SaveChanges();
            }
        }
    }
}