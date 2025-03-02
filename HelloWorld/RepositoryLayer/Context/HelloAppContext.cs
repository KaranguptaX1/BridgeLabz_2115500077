using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Entity;
namespace RepositoryLayer.Context
{
    public class HelloAppContext : DbContext
    {
        private readonly ILogger<HelloAppContext> _logger;
        public HelloAppContext(DbContextOptions<HelloAppContext> options,ILogger<HelloAppContext> logger):base(options)
        {
            _logger = logger;
            _logger.LogInformation("Database context initialized.");
        }

        public virtual DbSet<UserEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                _logger.LogWarning("Database context is not configured properly.");
            }
        }

        public override int SaveChanges()
        {
            _logger.LogInformation("Saving changes to the database.");
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Saving changes to the database asynchronously.");
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
