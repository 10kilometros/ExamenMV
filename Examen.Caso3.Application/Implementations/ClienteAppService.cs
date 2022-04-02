using Examen.Caso3.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Examen.Caso3.Application.Dtos;
using Examen.Caso3.Domain;
using Examen.Caso3.Domain.Aggregates.ClienteAgg;
using Examen.Caso3.Infrastructure.Crosscutting.ExceptionsTypes;
using Examen.Caso3.Infrastructure.Crosscutting.Resources;

namespace Examen.Caso3.Application.Implementations
{
    public class ClienteAppService : IClienteAppService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IClienteRepository _clienteRepository;
        readonly IMapper _mapper;

        public ClienteAppService(IUnitOfWork unitOfWork, IClienteRepository clienteRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException("unitOfWork");
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException("clienteRepository");
            _mapper = mapper ?? throw new ArgumentNullException("mapper");
        }

        public async Task<List<ClienteDto>> ObtenerAsync()
        {
            var clientes = await _clienteRepository.ObtenerAsync();
            return _mapper.Map<List<Cliente>, List<ClienteDto>>(clientes);
        }

        public async Task<ClienteDto> AgregarAsync(ClienteDto cliente)
        {
            var clienteEntity = _mapper.Map<ClienteDto, Cliente>(cliente);

            try
            {
                clienteEntity.Agregar();
                _clienteRepository.Add(clienteEntity);
                await _unitOfWork.CommitAsync();

                cliente.Id = clienteEntity.Id;
                return cliente;
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException error)
            {
                if (error.InnerException != null && error.InnerException.Message != null &&
                    error.InnerException.Message.Contains("Cannot insert duplicate key row in object"))
                {
                    throw new EntityDuplicateException(string.Format(Messages.EntidadDuplicada, cliente.Correo));
                }
            }
            catch (Exception error)
            {
                throw error;
            }

            return new ClienteDto();
        }
    }
}
