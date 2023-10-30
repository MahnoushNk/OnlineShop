using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.Migrations;
using Online_shop_web_app.Models;
using Online_shop_web_app.Models.Entities;
using Online_shop_web_app.Models.ResumeDbContext;

namespace Online_shop_web_app.Controllers
{
    public class ProductController : Controller
    {
        #region Ctor
        
        //Dependency injection
        private ResumeDbContext _context;

        public ProductController(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Get List Of Products
        [HttpGet]
        public async Task<IActionResult> ListOfProducts()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return View(products);

            #endregion
        }

    }
}
