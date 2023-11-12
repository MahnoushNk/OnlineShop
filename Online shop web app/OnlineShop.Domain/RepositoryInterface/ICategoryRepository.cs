using Online_shop_web_app.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.RepositoryInterface
{
    public interface ICategoryRepository
    {
        List<Category> GetListOfCategories();
    }

}


