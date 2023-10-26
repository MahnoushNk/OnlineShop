using Microsoft.AspNetCore.Mvc;
using Online_shop_web_app.Models.Entities;

namespace Online_shop_web_app.Controllers
{
    public class CategoryController : Controller
    {
        List<Category> categories = new List<Category>()
        {
            new Category() {Name = "Skin care" },
            new Category() {Name="cosmetic"},
            new Category() {Name="sanitary"},
            new Category() { Name = "perfume" },
            

        };
            
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
