using System;

namespace UsuarioyClave
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables:
            string usuario = "";
            string clave = "";

            Console.WriteLine("Introduce tu usuario");
            usuario = Console.ReadLine();

            while (usuario == "case sensitive")
            {
                Console.WriteLine("Ese no sirve, introduce otro");
                usuario = Console.ReadLine();
            }

            Console.WriteLine("Introduce tu clave");
            clave = Console.ReadLine();

            Console.WriteLine($"¿Es correcto el usuario {usuario} y la clave {clave}?");
        }
    }
}
