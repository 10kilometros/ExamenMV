using System;
using System.Collections.Generic;
using Examen.Caso3.Application.Contracts;
using Examen.Caso3.Application.Dtos;
using Examen.Caso3.Controllers;
using Examen.Caso3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Examen.Caso3.Pruebas
{
    [TestClass]
    public class Caso3Test
    {
        private List<ClienteDto> GetTestClientes()
        {
            return new List<ClienteDto>()
            {
                new ClienteDto()
                {
                    Id = 1,
                    Nombres = "Miguel",
                    ApellidosCompletos = "Villa",
                    Correo = "mvilla@gmail.com",
                    FechaNacimiento = DateTime.Now,
                    Direccion = "Jr. Jades 312",
                    FechaRegistro = DateTime.UtcNow,
                    Activo = true
                },
                new ClienteDto()
                {
                    Id = 2,
                    Nombres = "Marco",
                    ApellidosCompletos = "Olivos",
                    Correo = "molivos@gmail.com",
                    FechaNacimiento = DateTime.Now,
                    Direccion = "Jr. Jades 123",
                    FechaRegistro = DateTime.UtcNow,
                    Activo = true
                },
            };

        }

        [TestMethod]
        public void TestObtenerClientes()
        {
            var mockRepo = new Mock<IClienteAppService>();
            mockRepo.Setup(repo => repo.ObtenerAsync()).ReturnsAsync(GetTestClientes());

            ClienteController clienteController = new ClienteController(mockRepo.Object);
            var resultado = clienteController.Index().Result;

            Assert.IsInstanceOfType(resultado, typeof(ViewResult));

            var viewResult = (ViewResult)resultado;
            var clientes = (List<ClienteViewModel>)viewResult.Model;

            Assert.AreEqual(2, clientes.Count);
        }

        [TestMethod]
        public void TestRegistraClienteValido()
        {
            var mockRepo = new Mock<IClienteAppService>();

            var nuevoCliente = new ClienteCrearViewModel()
            {
                Nombres = "Marco",
                ApellidosCompletos = "Olivos",
                Correo = "miguel13@avances.com.pe",
                FechaNacimiento = DateTime.Now,
                Direccion = "Jr. Jades 123",
            };

            ClienteController clienteController = new ClienteController(mockRepo.Object);
            var resultado = clienteController.Crear(nuevoCliente).Result;

            Assert.IsInstanceOfType(resultado, typeof(RedirectToActionResult));

            var viewResult = (RedirectToActionResult)resultado;

            Assert.AreEqual("Index", viewResult.ActionName);
        }

        [TestMethod]
        public void TestRegistraClienteInvalido()
        {
            var mockRepo = new Mock<IClienteAppService>();

            var nuevoCliente = new ClienteCrearViewModel()
            {
                Correo = "miguel13@avances.com.pe",
                FechaNacimiento = DateTime.Now,
                Direccion = "Jr. Jades 123",
            };

            ClienteController clienteController = new ClienteController(mockRepo.Object);
            clienteController.ModelState.AddModelError("Nombres:", "Requerido.");
            clienteController.ModelState.AddModelError("Apellidos:", "Requerido.");
            var resultado = clienteController.Crear(nuevoCliente).Result;

            Assert.IsInstanceOfType(resultado, typeof(ViewResult));

            var viewResult = (ViewResult)resultado;

            Assert.AreEqual(false, viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(2, viewResult.ViewData.ModelState.ErrorCount);
        }
    }
}
