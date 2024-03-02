using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.entity;

namespace ShopApp.data.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
       List<Category> GetPopularCategories();
    }
}