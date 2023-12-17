using Online_shop_web_app.DTO.Siteside.Product;
using OnlineShop.Application.DTO.Siteside.User;
using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.services.Interfaces
{
    public interface IUserService
    {
        Task AddUserToTheDatabase(AddUserToTheDatabaseDTO model);

        Task<User> GetUser(UserLoginDTO model);

        Task<User> GetUser(UserProfileDTO model);
    }
}
