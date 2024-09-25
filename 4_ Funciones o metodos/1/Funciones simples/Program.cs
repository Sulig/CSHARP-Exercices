using System;

namespace Funciones_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarTitulo();
        }

        //Funcion "Mostrar titulo":

        private static void MostrarTitulo()
        {
            //Introducir datos:
            string[] titulo = FormatearTitulo();

            //Mostrar el titulo:
            for (int i = 0; i < titulo.Length; i++)
            {
                Console.WriteLine(titulo[i]);
            }
            
        }

        //Funcion "Formatear titulo":
        private static string[] FormatearTitulo()
        {
            //Introducir datos:
            Console.WriteLine("Introduce un titulo");
            string titulo = Console.ReadLine();

            string[] tituloF = new string[] { "************************", "****" + titulo.ToUpper() + "****", "************************" };
        
            return tituloF;
        }
    }
}