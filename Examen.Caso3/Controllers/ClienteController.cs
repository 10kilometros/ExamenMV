using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Examen.Caso3.Application.Contracts;
using Examen.Caso3.Application.Dtos;
using Examen.Caso3.Infrastructure.Crosscutting.ExceptionsTypes;
using Examen.Caso3.Models;
using Examen.Caso3.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Caso3.Controllers
{
    public class ClienteController : Controller
    {
        readonly IClienteAppService clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            this.clienteAppService = clienteAppService ?? throw new ArgumentNullException("clienteAppService");
        }

        // GET: ClienteController
        public async Task<ActionResult> Index()
        {
            List<ClienteDto> clientes = await clienteAppService.ObtenerAsync();
            List<ClienteViewModel> clientesViewModel = ClienteCreator.GetClientesViewModels(clientes);

            return View(clientesViewModel);
        }

        // GET: ClienteController/Crear
        public ActionResult Crear()
        {
            return View();
        }

        // POST: ClienteController/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Crear(ClienteCrearViewModel clienteViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(clienteViewModel);
                }

                ClienteDto cliente = ClienteCreator.GetClienteDto(clienteViewModel);
                await this.clienteAppService.AgregarAsync(cliente);

                return RedirectToAction(nameof(Index));
            }
            catch (EntityDuplicateException error)
            {
                ModelState.AddModelError("", error.Message);
            }
            catch
            {
                ModelState.AddModelError("", "Se produjo un error. Por favor contacte con Mesa de ayuda.");
            }

            return View(clienteViewModel);
        }
    }
}
