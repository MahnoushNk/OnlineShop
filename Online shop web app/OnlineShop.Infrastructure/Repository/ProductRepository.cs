using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.Models.Entities;
using Online_shop_web_app.Models.OnlineShopDbContext;
using OnlineShop.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        #region Ctor
        private readonly OnlineShopDbContext _context;

        public ProductRepository(OnlineShopDbContext context)
        {
            _context = context;
        }
        #endregion

        #region AddProductToShopCart
        public async Task AddProductToShopCart(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        #endregion

        #region DeleteProductFromShopCart
        public async Task DeleteProductFromShopCart(Product product)
        {

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
        #endregion

        #region GetListOfProducts

        public List<Product> GetListOfProducts()
        {
           return _context.Products.ToList();
        }
        #endregion

        #region GetProductByIdAsync
        public Task<Product> GetProductByIdAsync(int productId)
        {
            return _context.Products.FirstOrDefaultAsync(e => e.Id == productId);
        }

        #endregion
    }
}
