using System;

namespace Examen.Caso3.Domain.EntityBase
{
    public class Entity : IAuditoriaRegistro
    {
        public int Id { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
