

namespace OnlineShop.Domain.Entities;

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }     
        public string Description { get; set; }
        public WishList WishList { get; set; }
       
       




    }

