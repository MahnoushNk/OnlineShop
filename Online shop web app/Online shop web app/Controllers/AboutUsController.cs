using Microsoft.AspNetCore.Mvc;

namespace Online_shop_web_app.Controllers;

public class AboutUsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
