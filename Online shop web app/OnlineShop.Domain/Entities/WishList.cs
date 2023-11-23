using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Domain.Entities;


public class WishList
{
    public int Id { get; set; }
    public int UserId { get; set; }   
    public ICollection<Product> Products { get; set;}
}