using System.Collections.Generic;
using System.Threading.Tasks;
using Examen.Caso3.Domain;
using Microsoft.EntityFrameworkCore;

namespace Examen.Caso3.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        protected readonly DbSet<TEntity> _entities;

        public Repository(DbContext context)
        {
            Context = context;
            _entities = Context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }
    }
}
