using Microsoft.AspNetCore.Mvc;

namespace Online_shop_web_app.Controllers
{
    public class MyAccountController : Controller
    {
        #region MyAccount

        [HttpGet]
        public ActionResult MyAccount()
        {
            return View();
        }

        #endregion
    }
}
