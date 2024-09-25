using System;

namespace Peticiones_sin_if
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables:
            int edad;
            string pais = "";
            
            Console.WriteLine("Introduce tu edad");
            edad = int.Parse(Console.ReadLine());

            while (edad <18)
            {
                    Console.WriteLine("No puedes pasar");
                    edad = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduce tu pais, con dos iniciales en mayusculas, ej: ES");
            pais = Console.ReadLine();

            switch (pais)
            {
                case "ES":   //En el caso de "ES", hacer ->
                    Console.WriteLine("Puedes pasar");
                    break;  // Se para.

                case "FR":   
                    Console.WriteLine("Puedes pasar");
                    break;

                case "PT":   
                    Console.WriteLine("Puedes pasar");
                    break; 

                default:  // Opcion para cuando no se cumple ninguna.
                    Console.WriteLine("No puedes pasar");
                    break;
            }
           // Console.WriteLine("Puedes pasar");

        }
    }
}
