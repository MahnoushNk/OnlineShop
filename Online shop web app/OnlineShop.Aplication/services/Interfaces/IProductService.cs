using Online_shop_web_app.DTO.Siteside.Product;
using Online_shop_web_app.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetListOfProducts();

        List<ListOfProductsDTO> GetListOfProductsDTOs();

        Task<Product> GetProductByIdAsync(int productId);

        Task AddProductToShopCartDTO(AddProductToShopCartDTO model);

        Task DeleteProductFromShopCartDTO(DeleteProductFromShopCartDTO model);
    }
}
