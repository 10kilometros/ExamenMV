using Examen.Caso1Y2;
using System;
using System.Collections.Generic;
using Examen.Caso1Y2.Caso2;

namespace Examen.RangosYOrdenarLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Requerimiento N° 01");

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

            Console.WriteLine("Usuarios sin ordenar");
            //MostrarUsuarios(usuarios);

            //List<Usuario> usuariosOrdenadosPorNombre = usuarios.OrdenarPorNombre();

            //Console.WriteLine("Usuarios ordenados por Nombre");
            //MostrarUsuarios(usuariosOrdenadosPorNombre);

            //List<Usuario> usuariosOrdenadosPorNombreApellido = usuarios.OrdenarPorNombreApellido();

            //Console.WriteLine("Usuarios ordenados por Nombre y Apellido");
            //MostrarUsuarios(usuariosOrdenadosPorNombreApellido);

            List<ulong> numerosPositivos = new List<ulong>() { 100, 96, 101, 102, 105 };
            List<ulong> nuevosNumerosPositivos = numerosPositivos.CompletarRango();

            foreach (var valor in nuevosNumerosPositivos)
            {
                Console.Write(valor + ",");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void MostrarUsuarios(List<Usuario> usuarios)
        {
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
