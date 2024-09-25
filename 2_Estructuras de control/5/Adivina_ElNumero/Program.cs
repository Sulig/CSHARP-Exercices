using System;

namespace Adivina_ElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables:
            int numIntroducido;
            int intentos = 6;

            //Numero aleatorio:
            Random r = new Random();
            int numeroAleatorio = r.Next(0, 100);

            //Presento
            Console.WriteLine("ADIVINA EL NUMERO");
            Console.WriteLine("El numero esta entre 1 y 100, ambos incluidos");
            Console.WriteLine($"Tienes {intentos} intentos");

            //Insertar numero:
            numIntroducido = int.Parse(Console.ReadLine());

            //Si el numero introducido no es el numero aleatorio:
            while (intentos != 0)
            {
                  if (numIntroducido == numeroAleatorio)
                  {
                    Console.WriteLine("¡Enorabuena!");
                    Console.WriteLine("¡Lo has adivinado!");
                    intentos = 0;
                  }

                   //Si el numero es mas pequeño:
                   else if (numIntroducido > numeroAleatorio)
                   {
                        Console.WriteLine("El numero es mas pequeño");
                        Console.WriteLine("Prueba otra vez");

                        //resto 1 intento
                        intentos -= 1;
                        Console.WriteLine($"Tienes {intentos} intentos");

                        numIntroducido = int.Parse(Console.ReadLine());
                   }

                    //Si el numero es mas grande:
                    else if (numIntroducido < numeroAleatorio)
                    {
                        Console.WriteLine("El numero es mas grande");
                        Console.WriteLine("Prueba otra vez");

                        //resto 1 intento
                        intentos -= 1;
                        Console.WriteLine($"Tienes {intentos} intentos");
                        numIntroducido = int.Parse(Console.ReadLine());
                    }

                  else if (intentos == 0)
                  {
                    Console.WriteLine("No te quedan mas intentos");
                    Console.WriteLine($"La respuesta era {numeroAleatorio}");
                  }
            }
        }
    }
}
