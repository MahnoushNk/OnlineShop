﻿

namespace Online_shop_web_app.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
       public int CommentId { get; set; } 

        public string? Description { get; set; }
        public int AvailableProduct { get; set; }
        public List<RelatedProcuct> relatedProcucts { get; set; }

        public List<ShareProduct> shareProducts { get; set; }






    }
}
