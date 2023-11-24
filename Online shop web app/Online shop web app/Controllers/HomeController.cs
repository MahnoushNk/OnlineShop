using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Entities;
using OnlineShop.Application.Services.Interfaces;
using System.Diagnostics;

namespace Online_shop_web_app.Controllers
{

    public class HomeController : Controller
    {

        private readonly IDashboardService _dashboardService;
        public HomeController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;

        }

        public async Task<IActionResult> Index()
        {
            var model = await _dashboardService.FillDashboardModel();

            return View(model);
        }

    }
}