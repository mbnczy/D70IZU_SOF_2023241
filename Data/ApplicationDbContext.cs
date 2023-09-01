using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoeWebshop.Models;

namespace ShoeWebshop.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Color> Colors { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}

