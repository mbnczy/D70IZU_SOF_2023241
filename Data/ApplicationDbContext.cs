using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoeWebshop.Models;

namespace ShoeWebshop.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Color> Colors { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Shoe> Shoes { get; set; }
    public DbSet<SpecificShoe> Specific_shoe_details { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<PurchaseItem> Purchase_items { get; set; }
    public DbSet<SiteUser> SiteUsers { get; set; }



    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}

