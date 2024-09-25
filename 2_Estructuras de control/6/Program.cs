using System;

namespace El_Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables:
            string[] palabraOculta = { "K", "i", "r", "b", "y" };
            string[] palabraPantalla = { "-", "-", "-", "-", "-" };
            string palabraIntroducida = "";
            int intentos = 5;

            //Presento:
            Console.WriteLine("El juego del ahorcado");
            Console.WriteLine("Adivina la palabra");

            //Muestra por pantalla "-----"
            Console.WriteLine($"{palabraPantalla[0]} {palabraPantalla[1]} {palabraPantalla[2]} {palabraPantalla[3]} {palabraPantalla[4]}");

            while (intentos > -1) 
            {
                //Mira cada caso si coincide con alguna letra del ahorcado.
                if (palabraPantalla[0] != palabraOculta[0] || palabraPantalla[1] != palabraOculta[1] || palabraPantalla[2] != palabraOculta[2] || palabraPantalla[3] != palabraOculta[3] || palabraPantalla[4] != palabraOculta[4])
                {

                    //Inserta los datos:
                    Console.WriteLine("Introduce una letra");
                    palabraIntroducida = Console.ReadLine();

                    switch (palabraIntroducida)
                    {
                        case "K":
                            //Intercambia - por la letra correspondiente
                            palabraPantalla[0] = "K";

                            //Muestra por pantalla "K----"
                            Console.WriteLine($"{palabraPantalla[0]} {palabraPantalla[1]} {palabraPantalla[2]} {palabraPantalla[3]} {palabraPantalla[4]}");
                            break;

                        case "k":
                            //Intercambia - por la letra correspondiente
                            palabraPantalla[0] = "K";

                            //Muestra por pantalla "K----"
                            Console.WriteLine($"{palabraPantalla[0]} {palabraPantalla[1]} {palabraPantalla[2]} {palabraPantalla[3]} {palabraPantalla[4]}");
                            break;

                        case "i":
                            //Intercambia - por la letra correspondiente
                            palabraPantalla[1] = "i";

                            //Muestra por pantalla "-i---"
                            Console.WriteLine($"{palabraPantalla[0]} {palabraPantalla[1]} {palabraPantalla[2]} {palabraPantalla[3]} {palabraPantalla[4]}");
                            break;

                        case "r":
                            //Intercambia - por la letra correspondiente
                            palabraPantalla[2] = "r";

                            //Muestra por pantalla "--r--"
                            Console.WriteLine($"{palabraPantalla[0]} {palabraPantalla[1]} {palabraPantalla[2]} {palabraPantalla[3]} {palabraPantalla[4]}");
                            break;

                        case "b":
                            //Intercambia - por la letra correspondiente
                            palabraPantalla[3] = "b";

                            //Muestra por pantalla "---b-"
                            Console.WriteLine($"{palabraPantalla[0]} {palabraPantalla[1]} {palabraPantalla[2]} {palabraPantalla[3]} {palabraPantalla[4]}");
                            break;

                        case "y":
                            //Intercambia - por la letra correspondiente
                            palabraPantalla[4] = "y";

                            //Muestra por pantalla "----y"
                            Console.WriteLine($"{palabraPantalla[0]} {palabraPantalla[1]} {palabraPantalla[2]} {palabraPantalla[3]} {palabraPantalla[4]}");
                            break;

                        default:
                                if (intentos == 5)
                                {
                                    Console.WriteLine(" | ");
                                    Console.WriteLine(" O ");
                                }

                                else if (intentos == 4)
                                {
                                    Console.WriteLine(" | ");
                                    Console.WriteLine(" O ");
                                    Console.WriteLine(" I ");
                                }

                                else if (intentos == 3)
                                {
                                    Console.WriteLine(" | ");
                                    Console.WriteLine(" O ");
                                    Console.WriteLine("-I ");
                                }

                                else if (intentos == 2)
                                {
                                    Console.WriteLine(" | ");
                                    Console.WriteLine(" O ");
                                    Console.WriteLine("-I-");
                                }

                                else if (intentos == 1)
                                {
                                    Console.WriteLine(" | ");
                                    Console.WriteLine(" O ");
                                    Console.WriteLine("-I-");
                                    Console.WriteLine("/ ");
                                }

                                else if (intentos == 0)
                                {
                                    //Si no te quedan intentos ->

                                    Console.WriteLine(" | ");
                                    Console.WriteLine(" O ");
                                    Console.WriteLine("-I-");
                                    Console.WriteLine("//");

                                    Console.WriteLine("La respuesta era kirby");
                                }

                                intentos--;
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Has ganado");
                    intentos = -1;
                }
            } 
        }
    }
}
