using System;

namespace Usuario_Y_Clave
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

            Console.WriteLine("Introduce tu clave");
            clave = Console.ReadLine();

            Console.WriteLine($"¿Es correcto el usuario {usuario} y la clave {clave}?");
        }
    }
}
