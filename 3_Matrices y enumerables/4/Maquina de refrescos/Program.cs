using System;

namespace Maquina_de_refrescos
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES:
            int num;
            string respuesta = "si";

            //Matriz de elementos:
            string[] maquina = new String[] { "Agua", "Cocacola", "Fanta", "Sprite"};

            while (respuesta == "si")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                //Presento:
                Console.WriteLine("Que quieres pedir:");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i}: {maquina[i]}");
                }

                //Introducir datos:
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    //Color **|
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"{maquina[0]} vale 0'75E");
                }

                else if (num == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($"{maquina[1]} vale 1'50E");
                }

                else if (num == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($"{maquina[2]} vale 1'20E");
                }

                else if (num == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($"{maquina[3]} vale 1'25E");
                }

                Console.WriteLine("Quieres pedir algo mas?");
                respuesta = Console.ReadLine();
            }


            /*Cambiar el Color:
             //Forma 1, fondo:
             Console.BackgroundColor = ConsoleColor.Blue;
             Console.Clear();

             //Forma 2, fondo de las letras:
             Console.BackgroundColor = ConsoleColor.Blue;

             //Forma 3, color de las letras:
             Console.ForegroundColor = ConsoleColor.Blue;
            */
        }
    }
}
