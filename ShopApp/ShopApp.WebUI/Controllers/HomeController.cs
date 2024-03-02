using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.business.Abstract;
using ShopApp.data.Abstract;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController:Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService=productService;
        }

        public IActionResult Index()
        {

            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetAll()
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