using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.data.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
       List<Category> GetPopularCategories();
    }
}