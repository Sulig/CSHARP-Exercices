using System;

namespace Funcion_par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] num = new float[] { 1, 2, 3 };

            //Introduce datos:
            Console.WriteLine("Introduce un numero");
            num[0] = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otro numero");
            num[1] = float.Parse(Console.ReadLine());

            ParImpar(num);
        }

        //Funcion que mira si es par o es impar:
        private static void ParImpar(float[] num)
        {
         //Par/Impar ----------------------------------------------------------------->
            //Mirar si el numero es par o impar y poner una boolena en true o false.
            num[2] = num[0] % 2;

               //Num 1:
                 //Par:
                 if (num[2] == 0)
                 {
                   Console.WriteLine($"{num[0]} es par");
                 }

                 //Impar: (false):
                 else if (num[2] == 1)
                 {
                   Console.WriteLine($"{num[0]} es impar");
                 }

            //Mirar si el numero es par o impar y poner una boolena en true o false.
            num[2] = num[1] % 2;

              //Num 2:
                //Par:
                if (num[2] == 0)
                {
                  Console.WriteLine($"{num[1]} es par");
                }

               //Impar: (false):
               else if (num[2] == 1)
               {          
                 Console.WriteLine($"{num[1]} es impar");
               }

            //Multiplo o no:
           EsMultiplo(num);
        }


        //Funcion que mira si un numero es multiplo:
        private static void EsMultiplo(float[] num)
        {
            //Para que la division sea buena, hay que poner primero el numero mayor y luego el menor:
            if (num[0] < num[1])
            {
                num[2] = num[1] % num[0];
            }

            else 
            {
                num[2] = num[0] % num[1];
            }

            //Es multiplo o no:

            if (num[2] == 0)
            {
                Console.WriteLine($"{num[0]} es multiplo de {num[1]}");
            }

            else
            {
                Console.WriteLine($"{num[0]} no es multiplo de {num[1]}");
            }
        }
    }
}
