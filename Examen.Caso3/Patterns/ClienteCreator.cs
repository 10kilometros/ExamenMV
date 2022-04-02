using System.Collections.Generic;
using System.Linq;
using Examen.Caso3.Application.Dtos;
using Examen.Caso3.Models;

namespace Examen.Caso3.Patterns
{
    public static class ClienteCreator
    {
        public static ClienteDto GetClienteDto(ClienteCrearViewModel clienteViewModel)
        {
            return new ClienteDto()
            {
                Nombres = clienteViewModel.Nombres,
                ApellidosCompletos = clienteViewModel.ApellidosCompletos,
                Correo = clienteViewModel.Correo,
                FechaNacimiento = clienteViewModel.FechaNacimiento,
                Direccion = clienteViewModel.Direccion,
            };
        }

        public static List<ClienteViewModel> GetClientesViewModels(List<ClienteDto> clientes)
        {
            List<ClienteViewModel> clientesViewModels = clientes.Select(cliente => new ClienteViewModel()
            {
                Id = cliente.Id,
                NombresApellidos = $"{cliente.Nombres} {cliente.ApellidosCompletos}",
                Correo = cliente.Correo,
                FechaNacimiento = cliente.FechaNacimiento,
                Direccion = cliente.Direccion,
                FechaRegistro = cliente.FechaRegistro,
            }).ToList();

            return clientesViewModels;
        }
    }
}
