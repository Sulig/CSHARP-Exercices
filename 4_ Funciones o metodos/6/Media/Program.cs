using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular media");
            Console.WriteLine(CalculaMedia());
        }

        //Funcion que calcula la media de la matriz:
        private static float CalculaMedia()
        {
            //Intoduce info + variables:
            Console.WriteLine("Cuantos numeros quieres introducir?");
            int cantidad = int.Parse(Console.ReadLine());

            //Matriz y llenarla:
            float[] matriz = new float[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Introduce el numero {i + 1}");
                matriz[i] = float.Parse(Console.ReadLine());
            }

            //Total de la matriz:
            float total = 0;

             for (int x = 0; x < cantidad; x++)
             {
                total += matriz[x];
             }

            //Media:
            float media = total / cantidad;

            return media;
        }
    }
}
