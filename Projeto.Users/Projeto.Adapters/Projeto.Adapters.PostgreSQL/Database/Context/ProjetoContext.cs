using Microsoft.EntityFrameworkCore;

namespace Projeto.Adapters.PostgreSQL.Database.Context
{
    public class ProjetoContext(DbContextOptions options): DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}