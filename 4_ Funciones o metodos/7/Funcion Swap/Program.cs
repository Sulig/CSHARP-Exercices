using System;

namespace Funcion_Swap
{
    class Program
    {
        public static void interchange(ref int a, ref int b) //Ayuda de: https://www.w3resource.com/csharp-exercises/function/csharp-function-exercise-6.php
        {
            int newnum;

            newnum = a;
            a = b;
            b = newnum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Funcion Swap");
            FuncionSwap();
        }

        private static void FuncionSwap()
        {
            //Insertar datos:
            Console.WriteLine("Introduce un numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otro numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Estos son los numeros que has introducido: 1- {n1} y  2- {n2}");

            Console.WriteLine("El primer numero ahora sera el segundo y el segundo sera el primero");
            interchange(ref n1, ref n2);
            Console.WriteLine($"De tal forma que {n2} es el primer numero y {n1} es el segundo");
        }
    }
}
