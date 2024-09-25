using System;

namespace CalcularAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Las variables:
            int bas = 0;
            int altura = 0;
            int area = 0;

            Console.WriteLine("Para calcular el área del triangulo, necesitaré tú base y la altura");
            Console.WriteLine("Introduce el valor de la base");
            bas = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el valor de la altura");
            altura = int.Parse(Console.ReadLine());

            // Funcion: 
            area = bas * (altura/2);

            //Lee el resultado:
            Console.WriteLine("Tú área es: " + area);
        }
    }
}
