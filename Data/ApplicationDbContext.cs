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
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole{ Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole{ Id = "2", Name = "Staff", NormalizedName = "STAFF" }
        );

        builder.Entity<Size>().HasData(
            new Size { SizeID = "1", Value = "UK - 6", Details = "" },
            new Size { SizeID = "2", Value = "UK - 6.5", Details = "" },
            new Size { SizeID = "3", Value = "UK - 7", Details = "" },
            new Size { SizeID = "4", Value = "UK - 7.5", Details = "" },
            new Size { SizeID = "5", Value = "UK - 8", Details = "" },
            new Size { SizeID = "6", Value = "UK - 8.5", Details = "" },
            new Size { SizeID = "7", Value = "UK - 9", Details = "" },
            new Size { SizeID = "8", Value = "UK - 9.5", Details = "" },
            new Size { SizeID = "9", Value = "UK - 10", Details = "" }
        );


        builder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryID = Guid.NewGuid().ToString(),
                    Name = "Sneaker",
                    Description = "expensive"
                }
                );

        //builder.Entity<Brand>().HasData(
        //        new Brand()
        //        {
        //            BrandID = Guid.NewGuid().ToString(),
        //            Name = "Adidas",
        //            Country_of_origin = "Germany",
        //            Founded_year = new DateTime(1949,8,18)
        //        },
        //        new Brand()
        //        {
        //            BrandID = Guid.NewGuid().ToString(),
        //            Name = "Nike",
        //            Country_of_origin = "USA",
        //            Founded_year = new DateTime(1964, 1, 25)
        //        }
        //    );

        builder.Entity<Color>()
            .HasOne(x => x.Shoe)
            .WithMany()
            .HasForeignKey(x => x.ShoeID)
            .OnDelete(DeleteBehavior.SetNull);

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

