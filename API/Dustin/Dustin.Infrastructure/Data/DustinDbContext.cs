using Dustin.Domain.Entities;
using Dustin.Infrastructure.Seed;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Dustin.Infrastructure.Data
{
    public class DustinDbContext : DbContext
    {
        public DustinDbContext(DbContextOptions<DustinDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<SubFeature> SubFeatures { get; set; }
        public DbSet<ProductItemSubFeature> ProductItemSubFeatures { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductItemSubFeature>()
            .HasKey(bc => new { bc.SubFeatureId, bc.ProductItemId });

            modelBuilder.Entity<ProductItemSubFeature>()
                .HasOne(bc => bc.ProductItem)
                .WithMany(b => b.ProductItemSubFeatures)
                .HasForeignKey(bc => bc.ProductItemId);

            modelBuilder.Entity<ProductItemSubFeature>()
                .HasOne(bc => bc.SubFeature)
                .WithMany(c => c.ProductItemSubFeatures)
                .HasForeignKey(bc => bc.SubFeatureId);
         
            modelBuilder.Seed();
            modelBuilder.PropertyValidation();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is AuditEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {                  
                    ((AuditEntity)entry.Entity).CreatedAt = DateTime.UtcNow;
                }

                if (entry.State == EntityState.Modified)
                {                    
                    ((AuditEntity)entry.Entity).UpdatedAt = DateTime.UtcNow;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}