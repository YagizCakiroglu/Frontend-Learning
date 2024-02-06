﻿using System;
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

        // public DbSet<Order> Orders { get; set; }
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
    }

    // One to Many
    // One to One
    // Many to Many

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Customer Customer { get; set; }

        public List<Address> Addresses { get; set; } //Navigation Property
    }

    public class Customer 
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
        public int Id { get; set; }
       
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
            using(var db = new ShopContext())
            {
                // var customer = new Customer(){
                //         IdentityNumber="12313132",
                //         FirstName="Sadık",
                //         LastName="Turan",
                //         User = db.Users.FirstOrDefault(i=>i.Id==3)
                // };

                // db.Customers.Add(customer);
                // db.SaveChanges();


                var user = new User()
                {
                    Username = "deneme",
                    Email="deneme@gmail.com",
                    Customer = new Customer(){
                        FirstName="Deneme",
                        LastName="Deneme",
                        IdentityNumber="13213132"
                    }
                };

                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        static void InsertUsers()
        {
            var users = new List<User>(){
                new User(){Username="yagizcakiroglu",Email="info@yagizcakiroglu.com"},
                new User(){Username="yusufcakiroglu",Email="info@yusufcakiroglu.com"},
                new User(){Username="mehmetcakiroglu",Email="info@mehmetcakiroglu.com"},
                new User(){Username="tugbacakiroglu",Email="info@tugbacakiroglu.com"},
            };

            using(var db = new ShopContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
        }

        static void InsertAddresses()
        {
            var addresses = new List<Address>(){
                new Address(){Fullname="Yağız Çakıroğlu",Title="Ev adresi",Body="İstanbul",UserId=1},
                new Address(){Fullname="Yağız Çakıroğlu",Title="İş adresi",Body="İstanbul",UserId=1},
                new Address(){Fullname="Yusuf Çakıroğlu",Title="Ev adresi",Body="İstanbul",UserId=3},
                new Address(){Fullname="Mehmet Çakıroğlu",Title="İş adresi",Body="İstanbul",UserId=3},
                new Address(){Fullname="Tuğba Çakıroğlu",Title="İş adresi",Body="İstanbul",UserId=2},
                new Address(){Fullname="Tosun Çakıroğlu",Title="İş adresi",Body="İstanbul",UserId=4}
             
            };

            using(var db = new ShopContext())
            {
                db.Addresses.AddRange(addresses);
                db.SaveChanges();
            }
        }

    }
}
