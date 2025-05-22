using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto.Adapters.PostgreSQL.Database.Context;

namespace Projeto.Adapters.PostgreSQL.Database.Settings
{
    public class SoftDeletes(DbContextOptions<ProjetoContext> options) : ProjetoContext(options)
    {
    
    }
}