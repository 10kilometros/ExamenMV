using System.Collections.Generic;
using Examen.Caso1Y2.Caso2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examen.Caso1Y2.Pruebas
{
    [TestClass]
    public class Caso2Test
    {
        [TestMethod]
        public void TestCompletarRango()
        {
            List<ulong> numerosPositivos = new List<ulong>() { 22, 25 };
            List<ulong> nuevosNumerosPositivos = numerosPositivos.CompletarRango();
            List<ulong> numerosPositivosEsperado = new List<ulong>() { 22, 23, 24, 25 };

            CollectionAssert.AreEqual(numerosPositivosEsperado, nuevosNumerosPositivos);
        }

        [TestMethod]
        public void TestCompletarRangoSinRepetidos()
        {
            List<ulong> numerosPositivos = new List<ulong>() { 105, 100, 96, 101, 102 };
            List<ulong> nuevosNumerosPositivos = numerosPositivos.CompletarRango();
            List<ulong> numerosPositivosEsperado = new List<ulong>() { 96, 97, 98, 99, 100, 101, 102, 103, 104, 105 };

            CollectionAssert.AreEqual(numerosPositivosEsperado, nuevosNumerosPositivos);
        }

        [TestMethod]
        public void TestCompletarRangoConRepetidos()
        {
            List<ulong> numerosPositivos = new List<ulong>() { 1, 1, 3, 22, 7, 3, 4, 4, 55, 6, 51, 1 };
            List<ulong> nuevosNumerosPositivos = numerosPositivos.CompletarRango();
            List<ulong> numerosPositivosEsperado = new List<ulong>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55 };

            CollectionAssert.AreEqual(numerosPositivosEsperado, nuevosNumerosPositivos);
        }
        
        [TestMethod]
        public void TestResultadosUnicos()
        {
            List<ulong> numerosPositivos = new List<ulong>() { 1, 1, 3, 22, 7, 3, 4, 4, 55, 6, 51, 1 };
            List<ulong> nuevosNumerosPositivos = numerosPositivos.CompletarRango();

            CollectionAssert.AllItemsAreUnique(nuevosNumerosPositivos);
        }

        [TestMethod]
        public void TestValidarCantidadResultadosMinimo()
        {
            List<ulong> numerosPositivos = new List<ulong>() { 5 };
            List<ulong> nuevosNumerosPositivos = numerosPositivos.CompletarRango();

            Assert.AreEqual(1, nuevosNumerosPositivos.Count);
        }

        [TestMethod]
        public void TestValidarCantidadResultados()
        {
            List<ulong> numerosPositivos = new List<ulong>() { 5, 10 };
            List<ulong> nuevosNumerosPositivos = numerosPositivos.CompletarRango();

            Assert.AreEqual(6, nuevosNumerosPositivos.Count);
        }
    }
}
