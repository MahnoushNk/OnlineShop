using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.DTO.Siteside.Product;
using Online_shop_web_app.Models;
using OnlineShop.Domain.Entities;
using Online_shop_web_app.Models.OnlineShopDbContext;
using OnlineShop.Application.Services.Interfaces;

namespace Online_shop_web_app.Controllers
{
    public class ProductController : Controller
    {
        #region Ctor
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion

        #region Add Product To ShopCart

        public async Task AddProductToShopCart(AddProductToShopCartDTO model)
        {

            await _productService.AddProductToShopCartDTO(model);
          
        }

        #endregion

        #region DeleteProductFromShopCart

        [HttpGet]
        public async Task<IActionResult> DeleteProductFromShopCart(int productId)
        {
            #region Get A Product By Id

            var education = await _productService.GetProductByIdAsync(productId);

            #endregion
            return View(education);
        }

        [HttpPost]
        public async Task DeleteProductFromShopCart(DeleteProductFromShopCartDTO model)
        {
            await _productService.DeleteProductFromShopCartDTO(model);
        }

        #endregion
    
        #region List Of Products
        [HttpGet]
        public IActionResult ListOfProducts()
        {
            var model = _productService.GetListOfProductsDTOs();
            return View(model);
        }

        #endregion


    }


}
