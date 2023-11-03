using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.Models.Entities;
using Online_shop_web_app.Models.OnlineShopDbContext;

namespace Online_shop_web_app.Controllers
{
    public class CategoryController : Controller
    {
        #region Ctor 

        //Dependency Injection

        private OnlineShopDbContext _context;

        public CategoryController(OnlineShopDbContext context)
        {
            _context = context;
        }

        #endregion

        #region List of Ctegories
        public async Task<IActionResult> ListOfCategories()
        {

            List<Category> ListOfCategories = await _context.Categories.ToListAsync();

            return View();

        }

        #endregion
    }
}
