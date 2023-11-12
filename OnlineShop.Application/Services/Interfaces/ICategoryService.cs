using Online_shop_web_app.Models.Entities;
using OnlineShop.Application.DTO.Siteside.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetListOfCategories();

        List<ListOfCategoriesDTO> GetListOfCategoriesDTOs();
    }
}
