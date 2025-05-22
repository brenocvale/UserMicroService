using Microsoft.EntityFrameworkCore;
using Projeto.Adapters.PostgreSQL.Database.Context;
using Projeto.Core.Domain.Entities.Extensions;

namespace Projeto.Adapters.PostgreSQL.Database.Settings
{
    public class SoftDeletes(DbContextOptions<ProjetoContext> options) : ProjetoContext(options)
    {
        public void SoftDeletesConfigure()
        {
            var deletedEntries = ChangeTracker.Entries()
                .Where(entity => entity.Entity is BaseEntity
                    && entity.State is EntityState.Deleted);

            foreach (var entry in deletedEntries)
            {
                var entity = (BaseEntity)entry.Entity;

                entity.DeletedAt = DateTime.UtcNow;
                entity.UpdatedAt = DateTime.UtcNow;
                entry.State = EntityState.Modified;
            }
        }
    }
}