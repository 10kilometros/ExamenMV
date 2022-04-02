using System;
using System.Collections.Generic;
using System.Linq;

namespace Examen.Caso1Y2
{
    public static class Extensiones
    {
        public static List<T> Clone<T>(this IList<T> listaAClonar) where T : ICloneable
        {
            return listaAClonar.Select(item => (T)item.Clone()).ToList();
        }
    }
}
