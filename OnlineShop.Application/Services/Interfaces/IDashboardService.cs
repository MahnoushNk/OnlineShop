using Online_shop_web_app.DTO.Siteside.Home_Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Services.Interfaces
{
    public interface IDashboardService
    {
        Task<HomeIndexModelDTO> FillDashboardModel();
    }
}
