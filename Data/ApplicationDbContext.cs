using DesafioBlazor.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesafioBlazor.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<IBGE> IBGE { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        _ = builder.Entity<IBGE>(entity =>
        {
            entity.Property(x => x.Id).IsRequired().HasMaxLength(7);
            entity.Property(x => x.State).HasMaxLength(2);
            entity.Property(x => x.City).HasMaxLength(80);

            entity.HasKey(x => x.Id);

            entity.HasIndex(x => x.Id).IsUnique();
            entity.HasIndex(x => x.State);
            entity.HasIndex(x => x.City);
        });
    }
}
