using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.DTO.Siteside.Product;
using Online_shop_web_app.Models;
using Online_shop_web_app.Models.Entities;
using Online_shop_web_app.Models.OnlineShopDbContext;

namespace Online_shop_web_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly OnlineShopDbContext _context;

        public ProductController(OnlineShopDbContext context)
        {
            _context = context;
        }


        #region Add Product To ShopCart

        public async Task AddProductToShopCart(AddProductToShopCartDTO model)
        {
            #region ObjectMapping

            Product product = new Product();
            product.Id = model.Id;

            #endregion


            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

        }
        #endregion

        #region DeleteProductFromShopCart
        public async Task DeleteProductFromShopCart(AddProductToShopCartDTO model)
        {
            #region ObjectMapping

            Product product = new Product();
            product.Id = model.Id;

            #endregion

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

        }

        #endregion

        #region GetProductById 

        public async Task GetProductByIdAsync(GetProductByIdAsyncDTO model)
        {
            #region ObjectMapping

            Product product = new Product();
            product.Id = model.Id;

            #endregion

            _context.Products.FirstOrDefaultAsync(e => e.Id == model.Id);


        }
        #endregion

        #region ListOfProducts 

        public List<ListOfProductsDTO> GetListOfProducts()
        {
            #region  Get List Of Products From Database

            List<Product> products = _context.Products.ToList();

            #endregion

            #region ObjectMapping

            List<ListOfProductsDTO> returnModel = new List<ListOfProductsDTO>();

            foreach (var pro in products)
            {
                ListOfProductsDTO childModel = new ListOfProductsDTO();

                childModel.Name = pro.Name;
                childModel.Description = pro.Description;
                childModel.Price = pro.Price;

                returnModel.Add(childModel);


            }
            #endregion

            return returnModel;

        }
        #endregion


    }


}
