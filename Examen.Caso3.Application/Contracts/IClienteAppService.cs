using System.Collections.Generic;
using System.Threading.Tasks;
using Examen.Caso3.Application.Dtos;

namespace Examen.Caso3.Application.Contracts
{
    public interface IClienteAppService
    {
        Task<List<ClienteDto>> ObtenerAsync();
        Task<ClienteDto> AgregarAsync(ClienteDto cliente);
    }
}
