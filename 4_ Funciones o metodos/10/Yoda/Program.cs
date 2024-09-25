using System;

namespace Yoda
{
    class Program
    {
        static void Main(string[] args)
        {
            QueDiriaYoda();
            //Ayuda de: https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split#code-try-2
        }

        private static string[] QueDiriaYoda()
        {
            //Introducir datos:
            Console.WriteLine("Que quieres que diga Yoda?");
            string tuFrase = Console.ReadLine();

            //Matrices:
            string[] palabras = tuFrase.Split(" "); //Llenar la matriz con las palabras.

            Array.Reverse(palabras); //Para ordenarlos al reves.
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine(String.Join(" ", palabras));  //Para ver la lista

            return palabras;
        }
    }
}