using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category {Name="Telefonlar",Description="Telefon Kategorisi"},
                new Category {Name="Bilgisayar",Description="Bilgisayar Kategorisi"},
                new Category {Name="Elektronik",Description="Elektronik Kategorisi"}
            };

            return View(categories);
        }
    }
}