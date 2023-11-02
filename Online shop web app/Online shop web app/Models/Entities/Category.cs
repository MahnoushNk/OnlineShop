namespace Online_shop_web_app.Models.Entities;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Product> Products { get; set;}
    public ICollection<SubCategory> SubCategories { get; set;}
 


}
