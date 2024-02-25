using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1,Name="Iphone 12",Price=12000,Description="İyi Telefon",IsApproved=false, ImageUrl="1.jpg"},
                new Product {ProductId=2,Name="Iphone 13",Price=15000,Description="Çok İyi Telefon",IsApproved=true, ImageUrl="2.jpg"},
                new Product {ProductId=3,Name="Iphone 14",Price=17000,Description="Çok İyi Telefon",IsApproved=true, ImageUrl="3.jpg"},
                new Product {ProductId=4,Name="Iphone 15",Price=19000,Description="Çok İyi Telefon", ImageUrl="4.jpg"}
            };
        }

        public static List<Product> Products
        {
            get 
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p=>p.ProductId==id);
        }
    }
}