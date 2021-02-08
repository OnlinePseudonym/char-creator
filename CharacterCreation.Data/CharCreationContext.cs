using Microsoft.EntityFrameworkCore;
using CharacterCreation.Data.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace CharacterCreation.Data
{
    public class CharCreationContext : DbContext
    {
        public CharCreationContext(DbContextOptions<CharCreationContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<BaseClass> BaseClasses { get; set; }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var added = ChangeTracker.Entries<BaseEntity>().Where(entity => entity.State == EntityState.Added);

            foreach(var a in added)
            {
                a.Property(p => p.CreatedDate).CurrentValue = DateTime.UtcNow;
                a.Property(p => p.CreatedDate).IsModified = true;
                a.Property(p => p.UpdatedDate).CurrentValue = DateTime.UtcNow;
                a.Property(p => p.UpdatedDate).IsModified = true;
            }

            var updated = ChangeTracker.Entries<BaseEntity>().Where(entity => entity.State == EntityState.Modified);

            foreach (var u in updated)
            {
                u.Property(p => p.UpdatedDate).CurrentValue = DateTime.UtcNow;
                u.Property(p => p.UpdatedDate).IsModified = true;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
