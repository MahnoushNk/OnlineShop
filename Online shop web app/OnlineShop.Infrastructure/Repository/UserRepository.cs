﻿using OnlineShop.Domain.Entities;
using Online_shop_web_app.Models.OnlineShopDbContext;
using OnlineShop.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Application.DTO.Siteside.User;

namespace OnlineShop.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        #region Ctor
        private readonly OnlineShopDbContext _context;

        public UserRepository(OnlineShopDbContext context)
        {
            _context = context;
        }
        #endregion 

        public async Task AddUserToTheDatabase(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetAnUserByMobileAndPasswordAsync(string UserMobile, string Password)
        {

            return await _context.Users.FirstOrDefaultAsync(e => e.Mobile  == UserMobile.Trim()

                                                              && e.Password == Password);
        }

    
    }
}
