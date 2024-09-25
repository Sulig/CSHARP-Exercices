using System;

namespace Velocidad_Per
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculare la velocidad de tu personaje");
            Console.WriteLine($"La velocidad de tu personaje es: {GetSpeed()}");
        }

        private static float GetSpeed()
        {
            //Variables:
            float hipotenusa;

            //Introducir datos:
            Console.WriteLine("Introduce tu movimiento en el eje x");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce tu movimiento en el eje y");
            float y = float.Parse(Console.ReadLine());

            x = x * x;
            y = y * y;

            hipotenusa = x + y;

            float speed = (float)Math.Sqrt(hipotenusa); //Raiz cuadrada de "hipotenusa"

            return speed;
        }
    }
}
