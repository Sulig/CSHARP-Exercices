using System;

namespace Mayuscula_Minuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "";
            Console.WriteLine("Introduce una palabra");

            palabra = Console.ReadLine();
            Console.WriteLine($"{palabra} en mayuscula es {palabra.ToUpper()} y en minuscula es {palabra.ToLower()}");
        }
    }
}
