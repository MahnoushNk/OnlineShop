
using Microsoft.AspNetCore.Authentication.Cookies;
using Online_shop_web_app.Models.OnlineShopDbContext;
using OnlineShop.Application.services.Implementation;
using OnlineShop.Application.services.Interfaces;
using OnlineShop.Application.Services.Implementation;
using OnlineShop.Application.Services.Interfaces;
using OnlineShop.Domain.RepositoryInterface;
using OnlineShop.Infrastructure.Repository;

namespace Online_shop_web_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            #region Repositories

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
         
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

            builder.Services.AddScoped<IUserRepository, UserRepository>(); 

            builder.Services.AddDbContext<OnlineShopDbContext>();

            #endregion

            #region Services

            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddScoped<ICategoryService, CategoryService>();

            builder.Services.AddScoped<IUserService, UserService>();


            builder.Services.AddScoped<IDashboardService, DashboardService>();

            #endregion

            #region Authentication

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                // Add Cookie settings
                .AddCookie(options =>
                {
                    options.LoginPath = "/MyAccount/Login";
                    options.LogoutPath = "/MyAccount/Logout";
                    options.ExpireTimeSpan = TimeSpan.FromDays(30);
                });

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}