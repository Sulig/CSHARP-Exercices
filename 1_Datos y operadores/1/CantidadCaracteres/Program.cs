using System;

namespace CantidadCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "" ;
            Console.WriteLine("Introduce una palabra");

            palabra = Console.ReadLine();
            Console.WriteLine($"El numero de caracteres de {palabra} es {palabra.Length}");
        }
    }
}
