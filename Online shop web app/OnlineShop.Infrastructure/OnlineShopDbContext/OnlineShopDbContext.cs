using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Entities;

namespace Online_shop_web_app.Models.OnlineShopDbContext;

public class OnlineShopDbContext : DbContext
{

    #region Ctor
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-R8LD9GE;Initial Catalog=OnlineShop;Integrated Security=True;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
    #endregion


    #region DbSet
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserInfo> UsersInfo { get; set; }
    public DbSet<WishList> WishList { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Checkout> Checkout { get; set; }
    public DbSet<Category_Product> CategoryProducts { get; set; }
    public DbSet<Category_SubCategory> CategorySubCategories { get; set; }
    public DbSet<User_product> UserProducts { get; set; }

    #endregion

    #region modelCreating
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Category>().HasMany(p => p.Products).WithOne(c => c.category);
        modelBuilder.Entity<Category>().HasMany(s => s.SubCategories).WithOne(c => c.category);
        modelBuilder.Entity<WishList>().HasMany(p => p.Products).WithOne(w => w.WishList);
        modelBuilder.Entity<Category_Product>().HasNoKey();
        modelBuilder.Entity<Category_SubCategory>().HasNoKey();
        modelBuilder.Entity<WishList_Product>().HasNoKey();
        modelBuilder.Entity<User_product>().HasNoKey();





    }


    #endregion
}
