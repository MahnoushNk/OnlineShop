namespace Online_shop_web_app.DTO.Siteside.Home_Index
{

    public class HomeIndexModelDTO
    {
        #region Properties
        public List<OnlineShop.Domain.Entities.Category> Categories { get; set; }

        //public List<Online_shop_web_app.Models.Entities.SubCategory> subCategories { get; set; }
        public List<OnlineShop.Domain.Entities.Product> Products { get; set; }


        #endregion
    }

}
