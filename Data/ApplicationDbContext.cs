using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GalacticGetaways.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Assuming `ApplicationUser` is your user entity
        modelBuilder.Entity<IdentityUser>()
            .Property(u => u.Id)
            .HasMaxLength(255) // Set the maximum length
            .HasColumnType("varchar(255)"); // Use VARCHAR(255) instead of TEXT

        // Apply the same configuration for other entities with string keys if necessary
    }
}
