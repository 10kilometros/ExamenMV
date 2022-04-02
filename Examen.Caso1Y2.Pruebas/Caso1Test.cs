using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examen.Caso1Y2.Pruebas
{
    [TestClass]
    public class Caso1Test
    {
        [TestMethod]
        public void TestOrdenarNombresSimples()
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario("Carlos", "Alcantara"),
                new Usuario("Luis", "Reyes"),
                new Usuario("Miguel", "Pinillos"),
                new Usuario("Miguelon", "Pinillos"),
                new Usuario("Alan", "Coronel"),
                new Usuario("Marcos", "Buis"),
                new Usuario("Soledad", "Villar"),
                new Usuario("Alberto", "Coronel"),
                new Usuario("Marco", "Villar"),
                new Usuario("Alberto", "Villar"),
                new Usuario("Adib", "Bacilio"),
                new Usuario("Alabin", "Pinillos"),
            };

            List<Usuario> usuariosOrdenadosPorNombre = usuarios.OrdenarPorNombre();

            List<Usuario> usuariosOrdenadosPorNombreEsperado = new List<Usuario>()
            {
                new Usuario("Adib", "Bacilio"),
                new Usuario("Alabin", "Pinillos"),
                new Usuario("Alan", "Coronel"),
                new Usuario("Alberto", "Coronel"),
                new Usuario("Alberto", "Villar"),
                new Usuario("Carlos", "Alcantara"),
                new Usuario("Luis", "Reyes"),
                new Usuario("Marco", "Villar"),
                new Usuario("Marcos", "Buis"),
                new Usuario("Miguel", "Pinillos"),
                new Usuario("Miguelon", "Pinillos"),
                new Usuario("Soledad", "Villar"),
            };

            CollectionAssert.AreEqual(usuariosOrdenadosPorNombreEsperado, usuariosOrdenadosPorNombre);
        }

        [TestMethod]
        public void TestOrdenarNombresCompuestos()
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario("Carlos Miguelon", "Alcantara Coronel"),
                new Usuario("Luis Marcos", "Reyes Buis"),
                new Usuario("Carmen Soledad", "Pinillos Buis"),
                new Usuario("", "Pinillos Buis"),
                new Usuario("Alan Alberto", "Coronel"),
                new Usuario(null, "Buis Alcantara"),
                new Usuario("Soledad María", "Villar"),
                new Usuario("Alberto Carlos", "Coronel Pinillos"),
                new Usuario("Marco Luis", "Villar Coronel"),
                new Usuario("Alberto Alan", "Villar Coronel"),
                new Usuario("Adib Marco", "Bacilio Pinillos"),
                new Usuario("Alabin Marco", "Alcantara Coronel"),
            };

            List<Usuario> usuariosOrdenadosPorNombre = usuarios.OrdenarPorNombre();

            List<Usuario> usuariosOrdenadosPorNombreEsperado = new List<Usuario>()
            {
                new Usuario("", "Pinillos Buis"),
                new Usuario(null, "Buis Alcantara"),
                new Usuario("Adib Marco", "Bacilio Pinillos"),
                new Usuario("Alabin Marco", "Alcantara Coronel"),
                new Usuario("Alan Alberto", "Coronel"),
                new Usuario("Alberto Alan", "Villar Coronel"),
                new Usuario("Alberto Carlos", "Coronel Pinillos"),
                new Usuario("Carlos Miguelon", "Alcantara Coronel"),
                new Usuario("Carmen Soledad", "Pinillos Buis"),
                new Usuario("Luis Marcos", "Reyes Buis"),
                new Usuario("Marco Luis", "Villar Coronel"),
                new Usuario("Soledad María", "Villar"),
            };

            CollectionAssert.AreEqual(usuariosOrdenadosPorNombreEsperado, usuariosOrdenadosPorNombre);
        }

        [TestMethod]
        public void TestOrdenarNombresApellidosSimples()
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario("Carlos", "Alcantara"),
                new Usuario("Luis", "Reyes"),
                new Usuario("Miguel", "Pinillos"),
                new Usuario("Miguelon", "Pinillos"),
                new Usuario("Alan", "Coronel"),
                new Usuario("Marcos", "Buis"),
                new Usuario("Soledad", "Villar"),
                new Usuario("Alberto", "Villar"),
                new Usuario("Alberto", "Coronel"),
                new Usuario("Marcos", "Villar"),
                new Usuario("Adib", "Bacilio"),
                new Usuario("Alabin", "Pinillos"),
            };

            List<Usuario> usuariosOrdenadosPorNombre = usuarios.OrdenarPorNombreApellido();

            List<Usuario> usuariosOrdenadosPorNombreEsperado = new List<Usuario>()
            {
                new Usuario("Adib", "Bacilio"),
                new Usuario("Alabin", "Pinillos"),
                new Usuario("Alan", "Coronel"),
                new Usuario("Alberto", "Coronel"),
                new Usuario("Alberto", "Villar"),
                new Usuario("Carlos", "Alcantara"),
                new Usuario("Luis", "Reyes"),
                new Usuario("Marcos", "Buis"),
                new Usuario("Marcos", "Villar"),
                new Usuario("Miguel", "Pinillos"),
                new Usuario("Miguelon", "Pinillos"),
                new Usuario("Soledad", "Villar"),
            };

            CollectionAssert.AreEqual(usuariosOrdenadosPorNombreEsperado, usuariosOrdenadosPorNombre);
        }

        [TestMethod]
        public void TestOrdenarNombresApellidosCompuestos()
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario("Carlos Miguelon", "Alcantara Coronel"),
                new Usuario("Luis Marcos", "Reyes Buis"),
                new Usuario("Luis", "Reyes Buis"),
                new Usuario("Susana", ""),
                new Usuario("Alan Alberto", "Coronel"),
                new Usuario("Ana Susana", null),
                new Usuario("Soledad María", "Villar"),
                new Usuario("Alberto", "Coronel Pinillos"),
                new Usuario("Marco Luis", "Villar Coronel"),
                new Usuario("Alberto", "Villar Coronel"),
                new Usuario("Adib Marco", "Bacilio Pinillos"),
                new Usuario("Alabin Marco", "Alcantara Coronel"),
            };

            List<Usuario> usuariosOrdenadosPorNombre = usuarios.OrdenarPorNombreApellido();

            List<Usuario> usuariosOrdenadosPorNombreEsperado = new List<Usuario>()
            {
                new Usuario("Adib Marco", "Bacilio Pinillos"),
                new Usuario("Alabin Marco", "Alcantara Coronel"),
                new Usuario("Alan Alberto", "Coronel"),
                new Usuario("Alberto", "Coronel Pinillos"),
                new Usuario("Alberto", "Villar Coronel"),
                new Usuario("Ana Susana", null),
                new Usuario("Carlos Miguelon", "Alcantara Coronel"),
                new Usuario("Luis", "Reyes Buis"),
                new Usuario("Luis Marcos", "Reyes Buis"),
                new Usuario("Marco Luis", "Villar Coronel"),
                new Usuario("Soledad María", "Villar"),
                new Usuario("Susana", ""),
            };

            CollectionAssert.AreEqual(usuariosOrdenadosPorNombreEsperado, usuariosOrdenadosPorNombre);
        }

    }
}
