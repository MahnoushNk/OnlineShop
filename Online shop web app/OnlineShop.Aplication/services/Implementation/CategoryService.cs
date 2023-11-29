using Online_shop_web_app.DTO.Siteside.Product;
using OnlineShop.Domain.Entities;
using OnlineShop.Application.DTO.Siteside.Category;
using OnlineShop.Application.Services.Interfaces;
using OnlineShop.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        #region Ctor

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }

        #endregion

        #region GetListOfCategories

        public List<Category> GetListOfCategories()
        {
            return _categoryRepository.GetListOfCategories();
        }

        #endregion

        #region GetListOfCategoriesDTOs
        public List<ListOfCategoriesDTO> GetListOfCategoriesDTOs()
        {
            #region  Get List Of Categories From Database

            List<Category> categories = _categoryRepository.GetListOfCategories();

            #endregion

            #region ObjectMapping

            List<ListOfCategoriesDTO> returnModel = new List<ListOfCategoriesDTO>();

            foreach (var ct in categories)
            {
                ListOfCategoriesDTO childModel = new ListOfCategoriesDTO();

                childModel.Name = ct.Name;

                returnModel.Add(childModel);

            }

            #endregion

            return returnModel;
        }

        #endregion

    }
}
