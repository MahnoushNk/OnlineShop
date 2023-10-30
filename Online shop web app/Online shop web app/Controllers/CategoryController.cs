using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.Models.Entities;


namespace Online_shop_web_app.Controllers
{
    public class CategoryController : Controller
    {
        #region Get List Of Category

        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }
}
