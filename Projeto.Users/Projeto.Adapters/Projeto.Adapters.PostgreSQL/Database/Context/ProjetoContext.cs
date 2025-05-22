using Microsoft.EntityFrameworkCore;

namespace Projeto.Adapters.PostgreSQL.Database.Context
{
    public class ProjetoContext : DbContext
    {
        private readonly DbContextOptions _options;
        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        => _options = options; 
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}