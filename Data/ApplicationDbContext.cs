using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;
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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //builder.Entity<IdentityRole>().HasData(
        //    new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
        //    new { Id = "2", Name = "Staff", NormalizedName = "STAFF" },
        //    new { Id = "3", Name = "Customer", NormalizedName = "CUSTOMER" }
        //);
        builder.Entity<Purchase>()
            .HasOne(x => x.Customer)
            .WithMany()
            .HasForeignKey(x => x.CustomerID)
            .OnDelete(DeleteBehavior.SetNull);

        builder.Entity<PurchaseItem>()
            .HasOne(x => x.Purchase)
            .WithMany()
            .HasForeignKey(x => x.PurchaseID)
            .OnDelete(DeleteBehavior.SetNull);
        builder.Entity<PurchaseItem>()
            .HasOne(x => x.Specific_shoe_details)
            .WithMany()
            .HasForeignKey(x => x.Specific_shoe_detailsID)
            .OnDelete(DeleteBehavior.SetNull);

        builder.Entity<Shoe>()
            .HasOne(x => x.Category)
            .WithMany()
            .HasForeignKey(x => x.CategoryID)
            .OnDelete(DeleteBehavior.SetNull);
        builder.Entity<Shoe>()
            .HasOne(x => x.Brand)
            .WithMany()
            .HasForeignKey(x => x.BrandID)
            .OnDelete(DeleteBehavior.SetNull);

        builder.Entity<SpecificShoe>()
            .HasOne(x => x.Shoe)
            .WithMany()
            .HasForeignKey(x => x.ShoeID)
            .OnDelete(DeleteBehavior.SetNull);
        builder.Entity<SpecificShoe>()
            .HasOne(x => x.Color)
            .WithMany()
            .HasForeignKey(x => x.ColorID)
            .OnDelete(DeleteBehavior.SetNull);
        builder.Entity<SpecificShoe>()
            .HasOne(x => x.Size)
            .WithMany()
            .HasForeignKey(x => x.SizesID)
            .OnDelete(DeleteBehavior.SetNull);

        base.OnModelCreating(builder);

    }
}

