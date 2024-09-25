using System;

namespace Random_Range_Mejorado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Range. Mejorado");
            NumeroAleatorio();
        }

        private static void NumeroAleatorio()
        {
            //Variables:
            int minN = 2;
            int maxN = 2;
            int numeroAleatorio;

            //Numero aleatorio:
            Random r = new Random();

            //Que margen?:
            Console.WriteLine("numero minimo");
            minN = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero maximo");
            maxN = int.Parse(Console.ReadLine());

            //Cantidad:
            Console.WriteLine("Cuantos quieres?");
            int cantidad = int.Parse(Console.ReadLine());

            for(int i = 0; i < cantidad; i++)
            {
                numeroAleatorio = r.Next(minN, maxN);
                Console.WriteLine(numeroAleatorio);
            }
        }
    }
}
