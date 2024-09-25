using System;

namespace EscogerAccion_ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string opcion = "";
            int energia = 12;

            //Presento
            Console.WriteLine("Te encuentras en una ladera, no hay nada alrededor. ¿Que quieres hacer?");
            Console.WriteLine("Atacar (A), Dormir (D), Saltar (S) o Comer (C)");

            opcion = Console.ReadLine();

            // Si el jugador se confunde, se le repetira que vuelva a introducir algo:
            while (opcion != "A" && opcion != "D" && opcion != "S" && opcion != "C") //Si opcion no es A y no es D y no es S y no es C, haz ->
            {
                Console.WriteLine("Asegurate de usar la letra correspondiente");
                Console.WriteLine("Atacar (A), Dormir (D), Saltar (S) o Comer (C)");
                opcion = Console.ReadLine();
            }

            //Cada opcion esta separada con su case, en while ^, voy a poner que repita la acion y se asegure de usar la letra correspondiente
            switch (opcion)
            {
                case "A":
                Console.WriteLine("Atacas a una hoja que cae");
                    energia -= 2;
                    Console.WriteLine($"Tienes {energia} de energia");
                    break;

                case "D":
                    Console.WriteLine("Duermes en el suelo, ahora te sientes con mas energia");
                    energia += 2;
                    Console.WriteLine($"Tienes {energia} de energia");
                    break;

                case "S":
                    Console.WriteLine("Saltas, pero solo ves mas hierba");
                    energia -= 1;
                    Console.WriteLine($"Tienes {energia} de energia");
                    break;

                case "C":
                    Console.WriteLine("Comes un delicioso bocata preparado por ti");
                    energia += 1;
                    Console.WriteLine($"Tienes {energia} de energia");
                    break;
            }
        }
    }
}
