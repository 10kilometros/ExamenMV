using System;

namespace Examen.Caso1Y2
{
    public class Usuario : ICloneable, IOrdenamiento
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        public Usuario(string nombre, string apellido)
        {
            this.Nombre = LimpiarValor(nombre);
            this.Apellido = LimpiarValor(apellido);
        }

        private string LimpiarValor(string valor)
        {
            valor ??= string.Empty;
            valor = valor.Trim(new Char[] { ' ', '*', '.' });//Añadir más caracteres a limpiar

            return valor;
        }

        public string TextoNombres()
        {
            return Nombre;
        }

        public string TextoApellidos()
        {
            return Apellido;
        }

        public override bool Equals(object obj)
        {
            Usuario usuarioComparable = (Usuario) obj;
            return this.Nombre.Equals(usuarioComparable.Nombre) && this.Apellido.Equals(usuarioComparable.Apellido);
        }

        public override string ToString()
        {
            return $"-> {Nombre} {Apellido}";
        }

        public object Clone()
        {
            return new Usuario(Nombre, Apellido);
        }
    }
}
