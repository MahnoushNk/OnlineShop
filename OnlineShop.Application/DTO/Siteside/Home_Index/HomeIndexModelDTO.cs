namespace Online_shop_web_app.DTO.Siteside.Home_Index
{

    public class HomeIndexModelDTO
    {
        #region Properties
        public List<Online_shop_web_app.Models.Entities.Category> categories { get; set; }

        public List<Online_shop_web_app.Models.Entities.Checkout>  checkouts { get; set; }

        public List<Online_shop_web_app.Models.Entities.Payment> payments { get; set; }
        public List<Online_shop_web_app.Models.Entities.Product> products { get; set; }
        public List<Online_shop_web_app.Models.Entities.SubCategory> subCategories { get; set; }
        public List<Online_shop_web_app.Models.Entities.User> users { get; set; }
        public List<Online_shop_web_app.Models.Entities.UserInfo> userInfos { get; set; }
        public List<Online_shop_web_app.Models.Entities.WishList> wishLists { get; set; }

        #endregion
    }

}
