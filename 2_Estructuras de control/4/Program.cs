using System;

namespace Acertijo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables:
            string respuesta = "";
            int intentos = 3;

            //Presento:
            Console.WriteLine("Resuelve el siguiente acertijo:");
            Console.WriteLine($"Tienes 3 intentos");
            Console.WriteLine("¿De qué color es el caballo blanco de Santiago?");

            //Pido la respuesta:
            respuesta = Console.ReadLine();

            //En casos:
            while (intentos != 0)
            {
                switch (respuesta)
                {
                    case "blanco":
                        Console.WriteLine("Correcto");
                        intentos = 0;
                        Console.WriteLine($"Te quedan {intentos} intentos");
                        break;

                    case "Blanco":
                        Console.WriteLine("Correcto");
                        intentos = 0;
                        Console.WriteLine($"Te quedan {intentos} intentos");
                        break;

                    case "BLANCO":
                        Console.WriteLine("Correcto");
                        intentos = 0;
                        break;

                    default:
                        Console.WriteLine("Incorrecto");

                        //Resto 1 intento
                        intentos -= 1;

                        //Si no te quedan intentos
                        if (intentos == 0)
                        {
                            Console.WriteLine("No te quedan intentos, la respuesta era blanco");
                        }

                        //Si te quedan intentos
                        else
                        {
                            Console.WriteLine($"Te quedan {intentos} intentos");
                            Console.WriteLine("Intentalo otra vez");
                            respuesta = Console.ReadLine();
                        }

                        break;
                }
            }
        }
    }
}
