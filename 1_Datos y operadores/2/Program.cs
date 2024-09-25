using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            Console.WriteLine("Este es el valor inicial: " + num);
            Console.WriteLine("Se usara ++");
            num++;
            Console.WriteLine("Este es el valor final: " + num);
        }
    }
}
