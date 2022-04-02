using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen.Caso3.Domain.Aggregates.ClienteAgg
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<List<Cliente>> ObtenerAsync();
    }
}
