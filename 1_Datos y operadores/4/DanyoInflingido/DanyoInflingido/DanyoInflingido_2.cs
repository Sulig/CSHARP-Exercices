using System;

namespace DanyoInflingido
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidad = 12.8;
            double energia = 35.87;
            double distancia = 3;

            double danioInflingido = 56.65;
            Console.WriteLine("Calculare el danyo inflingido de tu persosaje, apartir de la velocidad, la energia y la distancia");

            Console.WriteLine("Introduce la velocidad");
            velocidad = int.Parse(Console.ReadLine());

            // Metodo 1, operador binario:
            velocidad = velocidad *3;

            Console.WriteLine("Introduce la energia");
            energia = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la distancia");
            distancia = int.Parse(Console.ReadLine());

            danioInflingido = (velocidad * 0.3 + energia * 0.5 + distancia * 0.2) / 2;
            Console.WriteLine($"El danyo inflingido es {danioInflingido}");
        }
    }
}