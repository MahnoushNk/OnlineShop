using Microsoft.EntityFrameworkCore;

namespace Online_shop_web_app.Models.Entities;


public class WishList
{
    public int Id { get; set; }
    public int UserId { get; set; }   
    public ICollection<Product> Products { get; set;}
}