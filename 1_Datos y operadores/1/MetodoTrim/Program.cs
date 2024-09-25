using System;

namespace MetodoTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "";
            Console.WriteLine("Introduce una palabra");

            palabra = Console.ReadLine();
            Console.WriteLine($"Ejemplo de frase para saber que hace {palabra.Trim()}  cuando lo pongo en esta frase");
        }
    }
}
