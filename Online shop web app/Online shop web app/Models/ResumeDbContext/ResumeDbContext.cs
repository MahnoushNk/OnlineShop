using Microsoft.EntityFrameworkCore;
using Online_shop_web_app.Models.Entities;

namespace Online_shop_web_app.Models.ResumeDbContext;

public class ResumeDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-R8LD9GE;Initial Catalog=OnlineShop;Integrated Security=True;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Checkout> Checkout { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<ShareProduct> shareProducts { get; set; }
    public DbSet<RelatedProcuct> relatedProcucts { get; set; }
    public DbSet<FavoriteProducts> FavoriteProducts { get; set;}
    public DbSet<Payment> payments { get; set; }
}
