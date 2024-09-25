using System;

namespace Puntuaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES:

            //Matriz de elementos:
            int[] pun = new int[] {7, 3, 4, 15, 8, 11};

            int max = pun[0];
            int min = pun[0];

            //Mostrar la puntuacion mas alta y la mas baja:
            //Mas alta:
            for (int i = 0; i < pun.Length; i++)
            {
                if (max < pun[i])
                {
                    max = 0;
                    max += pun[i];
                }
            }

            Console.WriteLine($"El maximo es: {max}");

            //Mas baja:
            for (int i = 0; i < pun.Length; i++)
            {
                if (min > pun[i])
                {                  
                    min = 0;
                    min += pun[i];
                }
            }

            Console.WriteLine($"El minimo es: {min}");
        }
    }
}
