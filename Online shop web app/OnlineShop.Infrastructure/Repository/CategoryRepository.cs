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
    public class CategoryRepository : ICategoryRepository
    {
        #region Ctor
        private readonly OnlineShopDbContext _context;

        public CategoryRepository(OnlineShopDbContext context)
        {
            _context = context;
        }
        #endregion

        #region GetListOfCategories
        public List<Category> GetListOfCategories()
        {
            return _context.Categories.ToList();
        }
        #endregion
    }
}
