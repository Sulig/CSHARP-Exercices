using System;
using System.Threading;

namespace Pausar_y_limpiar
{
    class Program
    {
        static void Main(string[] args)
        {
            //PAUSAR --------------------------------------------------------------------------------

            /*
            //Variables:
            string pal = "";

            //Introducir datos:
            Console.WriteLine("Introduce una palabra o frase");
            pal = Console.ReadLine();

            //Funcion Thread.Sleep(x) ->
            Thread.Sleep(2000); //Espera 2 segundos.
            Console.WriteLine($"{pal}");
            */

            //-------------------------------------------------------------------------------------------

            //PAUSAR Y LIMPIAR PARA UNA CUENTA ATRAS: ---------------------------------------------------

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); //Espera 1 segundo.
                Console.Clear(); //Limpia la accion
            }
        }
    }
}
