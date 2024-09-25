using System;

namespace SimbolosEspeciales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Funcion para imprimir en console simbolos especiales.
            System.Console.Out.WriteLine("56€");

            Console.WriteLine(Simbologia.Simbolos("€")); 
        }
    }
}