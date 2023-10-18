using System.ComponentModel;
using System.Text.Json;

namespace Online_shop_web_app.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
        public List<Comment> comments{ get; set; }
        public string Description { get; set; }
        public int AvailableProduct { get; set; }
        public List<RelatedProcuct> relatedProcucts { get; set; }

        public List<ShereProduct> shareProducts { get; set; }






    }
}
