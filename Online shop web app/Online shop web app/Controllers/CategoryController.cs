using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.Models.Entities;
using Online_shop_web_app.Models.ResumeDbContext;

namespace Online_shop_web_app.Controllers
{
    public class CategoryController : Controller
    {
        private ResumeDbContext _context;

        public CategoryController(ResumeDbContext context)
        {
            _context = context;
        }

        #region Get List Of Category
        [HttpGet]
        public async Task<IActionResult> ListOfCategory()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return View(categories);

            #endregion
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
