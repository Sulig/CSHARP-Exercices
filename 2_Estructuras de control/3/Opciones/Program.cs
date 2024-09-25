using System;

namespace Opciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string opcion = "";
            int energia = 12;
            int minEnergia = 0;

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

            Console.WriteLine("¿Quieres realizar otra accion?");
            Console.WriteLine("Si (Y), no (N)");
            opcion = Console.ReadLine();

            // Si el jugador se confunde, se le repetira que vuelva a introducir algo:
            while (opcion != "Y" && opcion != "N") //haz ->
            {
                Console.WriteLine("Asegurate de usar la letra correspondiente");
                Console.WriteLine("Si (Y), no (N)");
                opcion = Console.ReadLine();
            }

            //Si dice que si ->
            while (opcion == "Y")
            {
                Console.WriteLine("¿Que quieres hacer?");
                Console.WriteLine("Atacar (A), Dormir (D), Saltar (S) o Comer (C)");
                opcion = Console.ReadLine();

                // Si el jugador se confunde, se le repetira que vuelva a introducir algo:
                while (opcion != "A" && opcion != "D" && opcion != "S" && opcion != "C") //Si opcion no es A y no es D y no es S y no es C, haz ->
                {
                    Console.WriteLine("Asegurate de usar la letra correspondiente");
                    Console.WriteLine("Atacar (A), Dormir (D), Saltar (S) o Comer (C)");
                    opcion = Console.ReadLine();
                }

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

                // Si energia es 1 ->
                if (energia == 1)
                {
                    Console.WriteLine("¿Quieres realizar otra accion?");
                    Console.WriteLine("Si (Y), no (N)");
                    opcion = Console.ReadLine();

                    while (opcion == "Y")
                    {
                        Console.WriteLine("¿Que quieres hacer?");
                        Console.WriteLine("Atacar (A), Dormir (D), Saltar (S) o Comer (C)");
                        opcion = Console.ReadLine();


                        while (opcion == "A")
                        {
                            Console.WriteLine("No tienes suficiente energia");
                            Console.WriteLine("Puedes Comer (C), Dormir (D) o Saltar (S)");
                            opcion = Console.ReadLine();

                            switch (opcion)
                            {
                                case "D":
                                    Console.WriteLine("Duermes en el suelo, ahora te sientes con mas energia");
                                    energia += 2;
                                    Console.WriteLine($"Tienes {energia} de energia");
                                    break;

                                case "C":
                                    Console.WriteLine("Comes un delicioso bocata preparado por ti");
                                    energia += 1;
                                    Console.WriteLine($"Tienes {energia} de energia");
                                    break;


                                case "S":
                                    Console.WriteLine("Saltas, pero solo ves mas hierba");
                                    energia -= 1;
                                    Console.WriteLine($"Tienes {energia} de energia");
                                    break;
                            }
                        }
                    }
                }

                if (energia <= minEnergia)
                {
                    Console.WriteLine("¿Quieres realizar otra accion?");
                    Console.WriteLine("Si (Y), no (N)");
                    opcion = Console.ReadLine();

                    while (opcion == "Y")
                    {
                        Console.WriteLine("¿Que quieres hacer?");
                        Console.WriteLine("Atacar (A), Dormir (D), Saltar (S) o Comer (C)");
                        opcion = Console.ReadLine();


                        while (opcion == "A" || opcion == "S")
                        {
                            Console.WriteLine("No tienes suficiente energia");
                            Console.WriteLine("Puedes Comer (C) o Dormir (D)");
                            opcion = Console.ReadLine();

                            switch (opcion)
                            {
                                case "D":
                                    Console.WriteLine("Duermes en el suelo, ahora te sientes con mas energia");
                                    energia += 2;
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

                Console.WriteLine("¿Quieres realizar otra accion?");
                Console.WriteLine("Si (Y), no (N)");

                opcion = Console.ReadLine();

                while (opcion != "Y" && opcion != "N") //Si opcion no es A y no es D y no es S y no es C, haz ->
                {
                    Console.WriteLine("Asegurate de usar la letra correspondiente");
                    Console.WriteLine("Si (Y), no (N)");
                    opcion = Console.ReadLine();
                }
            }
            
            // Si dice que no, hara esto, para el si, es el while
            if (opcion == "N")
            {
                Console.WriteLine("Gracias por jugar");
            }
        }
    }
}
