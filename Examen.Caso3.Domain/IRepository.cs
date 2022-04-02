using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen.Caso3.Domain
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        void Add(TEntity entity);
    }
}
