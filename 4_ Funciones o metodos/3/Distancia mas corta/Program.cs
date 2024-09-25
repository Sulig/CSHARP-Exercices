using System;

namespace Distancia_mas_corta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"La distancia mas corta es: {DistanciaMasCorta()}");
        }

        //Funcion que mira cual es la distancia mas corta:
        private static int DistanciaMasCorta()
        {
            //Variables:
            int[] dis = new int[3] {1, 2, 3};

            //Introducir datos:
            Console.WriteLine("Introduce una distancia");
            dis[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otra distancia");
            dis[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce una ultima distancia");
            dis[2] = int.Parse(Console.ReadLine());

            int masCorta = dis[0];

            //Mirar cual es la mas pequeña:
            for (int i = 0; i< dis.Length; i++)
            {
                if(masCorta > dis[i])
                {
                    masCorta = 0;
                    masCorta += dis[i];
                }
            }

            return masCorta;
        }
    }
}
