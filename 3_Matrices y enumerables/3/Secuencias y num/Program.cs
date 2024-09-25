using System;

namespace Secuencias_y_num
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llenar una matriz con N numeros de 7 a n:

            //Variables:
            int numQueridos = 1;

            //Numero aleatorio:
            Random r = new Random();
            int numeroAleatorio = r.Next(4, 21);

            Console.WriteLine("Cuantos numeros quieres en esta serie?");
            numQueridos = int.Parse(Console.ReadLine());

            //Matriz
            int[] sequence = new int[numQueridos];  

            //Solo senares:
            for(int x = 0; x<numQueridos; x++)
            {
                //Llenar la matriz
                sequence[x] = numeroAleatorio;

                //Un nuevo numero aleatorio:
                numeroAleatorio = r.Next(4, 21);
            }

            //Ver el resultado:
            Console.WriteLine(String.Join(", ", sequence));  
        }
    }
}
