using OnlineShop.Domain.Entities;
using OnlineShop.Application.DTO.Siteside.User;
using OnlineShop.Application.services.Interfaces;
using OnlineShop.Domain.Entities;
using OnlineShop.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        public async Task AddUserToTheDatabase(AddUserToTheDatabaseDTO model)
        {
            #region ObjectMapping

            User user = new User();

            user.UserName = model.UserName;
            user.Password = model.Password;
            user.Mobile = model.Mobile.Trim();


            #endregion

            #region AddUserToTheDatabase

            await _userRepository.AddUserToTheDatabase(user);

            #endregion

        }

        public async Task<User> GetUser(UserProfileDTO model)
        {

            #region ObjectMapping

            User user = new User();

            user.UserName = model.UserName;          
            user.Mobile = model.Mobile.Trim();


            #endregion

            return await _userRepository.GetUser(model.Mobile);
        }

        public async Task<User> GetUser(UserLoginDTO model)
        {


            return await _userRepository.GetUser(model.Mobile, model.Password);
        }
        #endregion
    }

}
