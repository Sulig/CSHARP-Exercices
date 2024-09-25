using System;

namespace UsuarioYClave
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

            while (usuario != "admin" && clave != "1234")
            {
                Console.WriteLine("La clave o el usuario son incorrectos");
                Console.WriteLine("Introduce tu usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Introduce tu clave");
                clave = Console.ReadLine();
            }

            Console.WriteLine($"Bienvenido admin");
        }
    }
}
