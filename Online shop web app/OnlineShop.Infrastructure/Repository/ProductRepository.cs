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
        private readonly OnlineShopDbContext _context;

        public ProductRepository(OnlineShopDbContext context)
        {
            _context = context;
        }

        public async Task AddProductToShopCart(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductFromShopCart(Product product)
        {

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public List<Product> GetListOfProducts()
        {
           return _context.Products.ToList();
        }

        public Task<Product> GetProductByIdAsync(int productId)
        {
            return _context.Products.FirstOrDefaultAsync(e => e.Id == productId);
        }
    }
}
