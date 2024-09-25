using System;

namespace Danyo_al_jugador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Un enemigo va a atacarte!");
            DanyoAlJugador();
        }

        private static void DanyoAlJugador()
        {
            //Variables:
            double vida = 35;
            double porcentaje = 0.1;
            float poderen;

            //Introducir datos:
            Console.WriteLine("¿Cuanto poder de ataque tiene el enemigo?");
            double poderEn = double.Parse(Console.ReadLine());

            Console.WriteLine("Tienes el escudo puesto?");
            string respuesta = Console.ReadLine();

            switch (respuesta)
            {
                //Yes:
                case "yes":
                    respuesta = "Y";
                    break;

                case "Yes":
                    respuesta = "Y";
                    break;

                case "YES":
                    respuesta = "Y";
                    break;

                case "si":
                    respuesta = "Y";
                    break;

                case "Si":
                    respuesta = "Y";
                    break;

                case "SI":
                    respuesta = "Y";
                    break;

                case "sí":
                    respuesta = "Y";
                    break;

                case "Sí":
                    respuesta = "Y";
                    break;

                case "SÍ":
                    respuesta = "Y";
                    break;

                case "me lo pondre ahora":
                   Console.WriteLine("No cuela.");
                    respuesta = "N";
                    break;

                default:
                    respuesta = "N";
                    break;
            }

            if (respuesta == "Y")
            {
                poderEn *= porcentaje;
                vida -= poderEn;

                poderen = (float)poderEn; //Conversion de double a float;

                Console.WriteLine($"El enemigo te ha restado {poderen} puntos de vida.");
                Console.WriteLine($"Te quedan {vida} puntos de vida.");
            }

            else
            {
                vida -= poderEn;

                Console.WriteLine($"El enemigo te ha restado {poderEn} puntos de vida.");
                Console.WriteLine($"Te quedan {vida} puntos de vida.");
            }
        }
    }
}
