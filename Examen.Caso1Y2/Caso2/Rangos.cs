using System;
using System.Collections.Generic;
using System.Linq;

namespace Examen.Caso1Y2.Caso2
{
    public static class Rangos
    {
        public static List<ulong> CompletarRango(this IList<ulong> numerosPositivos)
        {
            int cantidadElementos = numerosPositivos.Count;

            if (cantidadElementos < 2)
            {
                return numerosPositivos.ToList();
            }

            Tuple<int, int> numeroMenorMayor = ObtenerNumeroMenorMayor(numerosPositivos);
            int numeroMenor = numeroMenorMayor.Item1;
            int numeroMayor = numeroMenorMayor.Item2;

            IList<ulong> nuevosNumerosPositivos = LlenarLista(numeroMenor, numeroMayor);

            return nuevosNumerosPositivos.ToList();
        }

        private static IList<ulong> LlenarLista(int numeroMenor, int numeroMayor)
        {
            int nuevaCantidadElementos = (int)(numeroMayor - numeroMenor + 1);

            ulong[] numeros = new ulong[nuevaCantidadElementos];

            for (int indice = 0; indice < nuevaCantidadElementos; indice++)
            {
                numeros[indice] = (ulong)(numeroMenor + indice);
            }

            return numeros;
        }

        private static Tuple<int, int> ObtenerNumeroMenorMayor(IList<ulong> numerosPositivos)
        {
            int cantidadElementos = numerosPositivos.Count;

            ulong numeroMenor = numerosPositivos[0];
            ulong numeroMayor = numeroMenor;

            for (int indice = 1; indice < cantidadElementos; indice++)
            {
                ulong numeroPositivo = numerosPositivos[indice];

                if (numeroPositivo < numeroMenor)
                {
                    numeroMenor = numeroPositivo;
                }
                else if (numeroPositivo > numeroMayor)
                {
                    numeroMayor = numeroPositivo;
                }
            }

            return new Tuple<int, int>((int)numeroMenor, (int)numeroMayor);
        }
    }
}
