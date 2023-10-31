

namespace Online_shop_web_app.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
        public  SubCategory subCategory { get; set; }
        public  int SubCategoryId  { get; set; }
        public int CommentId { get; set; } 
        public string? Description { get; set; }
        public int AvailableProduct { get; set; }
       




    }
}
