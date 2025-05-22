using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Adapters.PostgreSQL.Database.Repositories
{
    public class GenericRepository where T : class
    {
        public List<T> GetAllItem(T entity) 
    }
}