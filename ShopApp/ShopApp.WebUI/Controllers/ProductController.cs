using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
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



        public IActionResult List(int? id,string q,double? min_price,double? max_price) 
        {


            var products = ProductRepository.Products;

            if (id!=null)
            {
                products = products.Where(p=>p.CategoryId==id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i=>i.Name.Contains(q) || i.Description.Contains(q)).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products =products
            };

            return View(productViewModel);
        }


        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }


        public IActionResult Create(string name,double price)
        {
            Console.WriteLine(name);
            Console.WriteLine(price);
            return View();
        }
    }
}
