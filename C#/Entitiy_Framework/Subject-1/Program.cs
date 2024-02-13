using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Subject_1.Data.EfCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // using(var db = new NothwindContext())
            // {
            //     var city = "Miami";

            //    var customers = db.Customers
            //    .FromSqlRaw("select * from customers where city={0}",city).ToList();

            //    foreach (var item in customers)
            //    {
            //        Console.WriteLine(item.FirstName);
            //    }
            // }


            using(var db = new CustomNorthwindContext())
            {
                var customers = db.CustomerOrders
                .FromSqlRaw("select c.id,c.first_name,count(*) as count from customers c inner join orders o on c.id=o.customer_id group by c.id").ToList();

                foreach (var item in customers)
                {
                    Console.WriteLine("customer id: {0} firstname: {1} order count: {2}",item.CustomerId,item.FirstName,item.OrderCount);
                }
            }
        }
    }
}