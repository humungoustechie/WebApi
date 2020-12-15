using Melsoft.DataProvider.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melsoft.DataProvider
{
    /// <summary>
    /// Entity Framework - Data Context for Melsoft
    /// </summary>
    public class MelsoftDataContext : DbContext
    {
        public MelsoftDataContext(DbContextOptions<MelsoftDataContext> options) : base(options)
        {
        }

        // entity sets
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "Milkman").HasKey(x => x.Id);

                entity.Property(p => p.Id).HasColumnName("Id");
                entity.Property(p => p.Username).HasColumnName("Username");
                entity.Property(p => p.Forename).HasColumnName("Firstname");
                entity.Property(p => p.Surname).HasColumnName("Surname");
                entity.Property(p => p.Title).HasColumnName("Title");
                entity.Property(p => p.Email).HasColumnName("Email");
            });
        }
    }
}