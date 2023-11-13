using Online_shop_web_app.DTO.Siteside.Home_Index;
using Online_shop_web_app.Models.Entities;
using OnlineShop.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Services.Implementation
{
    public class DashboardService : IDashboardService
    {
        #region Ctor

        private readonly IProductService _productService;

        private readonly ICategoryService _categoryService;

        public DashboardService(IProductService productService,
                                ICategoryService categoryService
                               )

        {
            _categoryService = categoryService;
            _productService = productService;
           
        }
        #endregion

        public async Task<HomeIndexModelDTO> FillDashboardModel()
        {

            List<Product> products = _productService.GetListOfProducts();

            List<Category> categories = _categoryService.GetListOfCategories();


            HomeIndexModelDTO model = new HomeIndexModelDTO();

            model.Products = products;

            model.Categories = categories;

            return model;
        }
    }
}
