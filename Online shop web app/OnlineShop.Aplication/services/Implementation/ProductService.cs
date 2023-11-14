using Online_shop_web_app.DTO.Siteside.Product;
using Online_shop_web_app.Models.Entities;
using OnlineShop.Application.Services.Interfaces;
using OnlineShop.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Services.Implementation
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }

        public async Task AddProductToShopCartDTO(AddProductToShopCartDTO model)
        {
            #region ObjectMapping

            Product product = new Product();

            product.Id = model.ProductId;

            #endregion

            #region AddProductToShopCart

            await _productRepository.AddProductToShopCart(product);

            #endregion
        }

        #region DeleteProductFromShopCart

        public async Task DeleteProductFromShopCartDTO(DeleteProductFromShopCartDTO model)
        {

            #region ObjectMapping

            Product product = new Product();
            product.Id = model.ProductId;

            #endregion

            await _productRepository.DeleteProductFromShopCart(product);
        }

        #endregion

        #region ListOfProducts
        public List<Product> GetListOfProducts()
        {
            return _productRepository.GetListOfProducts();
        }
        #endregion

        #region ListOfProductsDTO

        public List<ListOfProductsDTO> GetListOfProductsDTOs()
        {
            #region  Get List Of Products From Database

            List<Product> products = _productRepository.GetListOfProducts();

            #endregion

            #region ObjectMapping

            List<ListOfProductsDTO> returnModel = new List<ListOfProductsDTO>();

            foreach (var pro in products)
            {
                ListOfProductsDTO childModel = new ListOfProductsDTO();

                childModel.Name = pro.Name;
                childModel.Description = pro.Description;
                childModel.Price = pro.Price;

                returnModel.Add(childModel);


            }
            #endregion

            return returnModel;

        }
        #endregion

        #region GetProductById

        public Task<Product> GetProductByIdAsync(int productId)
        {
            return _productRepository.GetProductByIdAsync(productId);
        }
        #endregion



    }
}



