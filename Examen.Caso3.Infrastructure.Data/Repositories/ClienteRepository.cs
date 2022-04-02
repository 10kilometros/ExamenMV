using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen.Caso3.Domain.Aggregates.ClienteAgg;
using Examen.Caso3.Infrastructure.Data.Context;

namespace Examen.Caso3.Infrastructure.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        readonly AppDbContext _context;
        #region Constructor
        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public ClienteRepository(AppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext as AppDbContext;
        }

        #endregion

        public async Task<List<Cliente>> ObtenerAsync()
        {
            var resultado = await this.GetAllAsync();

            return resultado.ToList();
        }

    }
}
