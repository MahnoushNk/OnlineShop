using Microsoft.AspNetCore.Mvc;
using Online_shop_web_app.Models;

namespace Online_shop_web_app.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product() {Name="chanel coco mademoiselle perfume"},
            new Product() {Name="Black opium perfume"},
            new Product() {Name="روغن مو آگاوه ماویی"},
            new Product() {Name="سپری دوفاز ایتالیایی "},
            new Product() {Name="سرم ضدآفتاب و جوانساز سیمپل"},
            new Product() {Name="ژل اسکراب میسلار پاک کننده صورت زیاجا"},
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
