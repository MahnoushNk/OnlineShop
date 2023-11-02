using Microsoft.AspNetCore.Mvc;

namespace Online_shop_web_app.Controllers;

public class ContactUsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
