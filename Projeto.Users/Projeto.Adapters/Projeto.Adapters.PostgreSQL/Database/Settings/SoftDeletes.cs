using Microsoft.EntityFrameworkCore;
using Projeto.Adapters.PostgreSQL.Database.Context;

namespace Projeto.Adapters.PostgreSQL.Database.Settings
{
    public class SoftDeletes(DbContextOptions<ProjetoContext> options) : ProjetoContext(options)
    {
    
    }
}