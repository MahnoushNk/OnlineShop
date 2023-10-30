using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.Models.Entities;

using System.Diagnostics;

namespace Online_shop_web_app.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}