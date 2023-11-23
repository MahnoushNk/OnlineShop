
using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.RepositoryInterface
{
    public interface IProductRepository
    {
        List<Product> GetListOfProducts();

        Task<Product> GetProductByIdAsync(int productId);

        Task AddProductToShopCart(Product product);

        Task DeleteProductFromShopCart(Product product); 
    }
}
