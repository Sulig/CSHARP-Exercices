using System;

namespace Distancias
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables:
            int distanciaEnemigoA;
            int distanciaEnemigoB;

            //Presento
            Console.WriteLine("Hola, tienes a dos enemigos delante tuyo. ¿Cual es la distancia del enemigo A?");
            Console.WriteLine("*Introduce tu valor en metros*");

            //Pido los datos
            distanciaEnemigoA = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cual es la distancia del enemigo B?");
            distanciaEnemigoB = int.Parse(Console.ReadLine());

            if (distanciaEnemigoA < distanciaEnemigoB)
            {
                Console.WriteLine("El enemigo mas cercano es el enemigo A");
            }

            else if (distanciaEnemigoA > distanciaEnemigoB)
            {
                Console.WriteLine("El enemigo mas cercano es el enemigo B");
            }

            else
            {
                Console.WriteLine("Los dos enemigos estan a la misma distancia");
            }
        }
    }
}
