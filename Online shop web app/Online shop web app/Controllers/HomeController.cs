using Microsoft.AspNetCore.Mvc;
using Online_shop_web_app.Models.Entities;
using System.Diagnostics;

namespace Online_shop_web_app.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<Product> products = new List<Product>()
        {
            new Product() {Name="chanel coco mademoiselle perfume", Price=500},
            new Product() {Name="Black opium perfume",Price = 500},
            new Product() {Name="روغن مو آگاوه ماویی", Price = 500},
            new Product() {Name="سپری دوفاز ایتالیایی ", Price = 500},
            new Product() {Name="سرم ضدآفتاب و جوانساز سیمپل", Price = 500},
            new Product() {Name="ژل اسکراب میسلار پاک کننده صورت زیاجا", Price = 500},
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(products);
        }

    }
}