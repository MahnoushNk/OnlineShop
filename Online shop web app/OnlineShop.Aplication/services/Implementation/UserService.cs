using Online_shop_web_app.Models.Entities;
using OnlineShop.Application.DTO.Siteside.User;
using OnlineShop.Application.services.Interfaces;
using OnlineShop.Domain.RepositoryInterface;
using OnlineShop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.services.Implementation
{
    public class UserService : IUserService
    {
        #region Ctor
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }
        #endregion

        #region AddUserToTheDatabase
        public async Task AddUserToTheDatabaseDTO(AddUserToTheDatabaseDTO model)
        {
            #region ObjectMapping

            User user = new User();

            user.Id = model.UderId;

            #endregion

            #region AddProductToShopCart

            await _userRepository.AddUserToTheDatabase(user);

            #endregion

        }
        #endregion
    }

}
