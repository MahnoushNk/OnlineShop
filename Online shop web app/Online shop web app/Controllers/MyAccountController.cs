using Microsoft.AspNetCore.Mvc;
using OnlineShop.Domain.Entities;
using Online_shop_web_app.Models.OnlineShopDbContext;
using OnlineShop.Application.services.Interfaces;
using OnlineShop.Application.Services.Interfaces;
using OnlineShop.Application.DTO.Siteside.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Online_shop_web_app.Controllers
{
    public class MyAccountController : Controller
    {

        #region Ctor


        private readonly IUserService _userService;

        public MyAccountController(IUserService userService)
        {
            _userService = userService;
        }
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
        public IActionResult Register(AddUserToTheDatabaseDTO model)
        {
            if (ModelState.IsValid)
            {
                //Add User to the database


               _userService.AddUserToTheDatabase(model);

                return RedirectToAction("Login", "MyAccount");
            }

           return View();
        }

        #endregion

        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult>  Login(UserLoginDTO model)
        {
            if (ModelState.IsValid)
            {
                #region Finde User 

                var user = await _userService.GetUser(model);
                                                        

                if (user == null)
                {
                    return NotFound();
                }


                #endregion

                #region Setting Cookie

                var claims = new List<Claim>
                {
                new (ClaimTypes.NameIdentifier, user.Id.ToString()),
                new (ClaimTypes.Name, user.UserName ),
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(claimIdentity);

                var authProps = new AuthenticationProperties();
                authProps.IsPersistent = model.RememberMe;

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProps);

                return RedirectToAction("MyAccount", "MyAccount");
                #endregion

            }
            return View();
        }

        #endregion


        #region Log Out

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        #endregion

        #region My Orders


        [HttpGet]
        public IActionResult MyOrders()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MyProfile(UserProfileDTO model)
        {
            _userService.GetUser(model);

            return View(model);

        }


        #endregion
    }

}
