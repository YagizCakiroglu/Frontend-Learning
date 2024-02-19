using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // ViewBag
            // Model
            // ViewData

            var product = new Product {Name="Iphone X",Price=6000,Description="Güzel Telefon"};

            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;



            return View(product);
        }

        public IActionResult List()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 12",Price=12000,Description="İyi Telefon",IsApproved=false},
                new Product {Name="Iphone 13",Price=15000,Description="Çok İyi Telefon",IsApproved=true},
                new Product {Name="Iphone 14",Price=17000,Description="Çok İyi Telefon",IsApproved=true},
                new Product {Name="Iphone 15",Price=19000,Description="Çok İyi Telefon"}
            };

            var category = new Category {Name="Telefonlar",Description="Telefon Kategorisi"};

            var productViewModel = new ProductViewModel()
            {
                Category = category,
                Products = products
            };

            return View(productViewModel);
        }


        public IActionResult Details(int id)
        {
            // name: "samsung s6"
            // price: 3000
            // description: "iyi telefon"

            // ViewBag.Name = "İphone 11";
            // ViewBag.Price = 3000;
            // ViewBag.Description = "İyi Telefon";

            var p = new Product();
            p.Name = "İphone 11";
            p.Price = 3000;
            p.Description = "İyi Telefon";

            return View(p);
        }
    }
}
