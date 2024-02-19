using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 12",Price=12000,Description="İyi Telefon",IsApproved=false},
                new Product {Name="Iphone 13",Price=15000,Description="Çok İyi Telefon",IsApproved=true},
                new Product {Name="Iphone 14",Price=17000,Description="Çok İyi Telefon",IsApproved=true},
                new Product {Name="Iphone 15",Price=19000,Description="Çok İyi Telefon"}
            };

            

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}