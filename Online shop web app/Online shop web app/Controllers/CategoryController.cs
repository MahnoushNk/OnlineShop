using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.Models.Entities;
using Online_shop_web_app.Models.OnlineShopDbContext;
using OnlineShop.Application.Services.Implementation;
using OnlineShop.Application.Services.Interfaces;

namespace Online_shop_web_app.Controllers
{
    public class CategoryController : Controller
    {
        #region Ctor 
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {

            _categoryService = categoryService;
        }

        #endregion

        #region List of Ctegories
        public async Task<IActionResult> ListOfCategories()
        {

            var model = _categoryService.GetListOfCategoriesDTOs();
            return View(model);

        }

        #endregion
    }
}
