namespace Online_shop_web_app.Models.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public Category category { get; set; }

    }
}
