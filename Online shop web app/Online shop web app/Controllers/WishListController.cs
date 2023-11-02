using Microsoft.AspNetCore.Mvc;

namespace Online_shop_web_app.Controllers;

public class WishListController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
