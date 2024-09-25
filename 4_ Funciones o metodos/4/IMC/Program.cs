using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcularé tu IMC");

            Console.WriteLine(CanJump());
        }

        //Calcular tu IMC
        private static float IMC()
        {
            //Variables: + info

            //Altura:
            Console.WriteLine("Introduce tu altura. *En centimetros*");
            float altura = float.Parse(Console.ReadLine());

            //Peso:
            Console.WriteLine("Introduce tu peso. *En Kilogramos*");
            float peso = float.Parse(Console.ReadLine());

            float imc;

            //Calculo del IMC:
            imc = peso / (altura * altura);
            imc *= 10000;

            Console.WriteLine($"Tu IMC es: {imc}");

            return imc;
        }

        //Funcion que analiza si puedes saltar:
        private static bool CanJump()
        {
            float imc = IMC();

            //Variables + info:
            Console.WriteLine("A que velocidad vas *m/s*");
            float vel = float.Parse(Console.ReadLine());
            bool canJump = true;

            //Puedes saltar si:
            if (imc < 30 && vel > 3)
            {
                canJump = true;
                Console.WriteLine("Podras saltar");
            }

            else
            {
                canJump = false;
                Console.WriteLine("No podras saltar");
            }

            return canJump;
        }
    }
}
