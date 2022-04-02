using System;
using System.Collections.Generic;

namespace Examen.Caso1Y2
{
    /// <summary>
    /// Clase que implementa metodos de ordenamiento de elementos por los criterios por 'Nombre' y 'Nombres y Apellidos'
    /// </summary>
    public static class OrdenarLista
    {
        /// <summary>
        /// Ordena de manera ascendente la lista de elementos por el atributo 'Nombre'
        /// </summary>
        /// <param name="lista">Lista de elementos a ordenar que implementa ICloneable, IOrdenamiento</param>
        /// <param name="tipoOrdenamiento">Determina el criterio de ordenamiento 'Ascendente' o 'Descendente'</param>
        public static List<T> OrdenarPorNombre<T>(this List<T> lista, CriterioOrdenamiento tipoOrdenamiento = CriterioOrdenamiento.Ascendente) where T : class, ICloneable, IOrdenamiento
        {
            List<T> listaAOrdenar = lista.Clone();
            listaAOrdenar.Sort((elementoA, elementoB) =>
            {
                int valorComparacion = String.Compare(elementoA.TextoNombres(), elementoB.TextoNombres(), StringComparison.OrdinalIgnoreCase);
                return valorComparacion * (int)tipoOrdenamiento;
            });

            return listaAOrdenar;
        }

        /// <summary>
        /// Ordena de manera ascendente la lista de elementos por el atributo 'Nombre' y luego por el 'Apellido'
        /// </summary>
        /// <param name="lista">Lista de elementos a ordenar que implementa ICloneable, IOrdenamiento</param>
        /// <param name="tipoOrdenamiento">Determina el criterio de ordenamiento 'Ascendente' o 'Descendente'</param>
        public static List<T> OrdenarPorNombreApellido<T>(this List<T> lista, CriterioOrdenamiento tipoOrdenamiento = CriterioOrdenamiento.Ascendente) where T : class, ICloneable, IOrdenamiento
        {
            List<T> listaAOrdenar = lista.Clone();
            listaAOrdenar.Sort((elementoA, elementoB) =>
            {
                int resultado = string.Compare(elementoA.TextoNombres(), elementoB.TextoNombres(), StringComparison.OrdinalIgnoreCase);
                return resultado != 0 ? resultado : string.Compare(elementoA.TextoApellidos(), elementoB.TextoApellidos(), StringComparison.OrdinalIgnoreCase) * (int)tipoOrdenamiento;
            });

            return listaAOrdenar;
        }
    }
}
