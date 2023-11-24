using Microsoft.AspNetCore.Mvc;
using OnlineShop.Domain.Entities;
using Online_shop_web_app.Models.OnlineShopDbContext;
using OnlineShop.Application.services.Interfaces;
using OnlineShop.Application.Services.Interfaces;
using OnlineShop.Domain.Entities;

namespace Online_shop_web_app.Controllers
{
    public class MyAccountController : Controller
    {

        #region Ctor

        private readonly OnlineShopDbContext _context;

        public MyAccountController(OnlineShopDbContext context)
        {
            _context = context;
        }
        //private readonly IUserService _userService;

        //public MyAccountController(IUserService userService)
        //{
        //    _userService = userService;
        //}
        #endregion

        #region MyAccount

        [HttpGet]
        public ActionResult MyAccount()
        {
            return View();
        }

        #endregion

        #region Register

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
           
            return RedirectToAction("Index","Home");
        }

        #endregion

        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            return View();
        }

        #endregion
    }
}
