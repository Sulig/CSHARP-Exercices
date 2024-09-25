using System;

namespace Precios_Vehiculos
{
    //Enumerables:
    enum TipoVehiculo { Moto, Coche, Furgoneta };
    enum TipoIva { Gasoil, Hibrido, Electrico };

    class Program
    {
        static void Main(string[] args)
        {
            //Definir una variable de un enumerador:
            /*
            TipoVehiculo vehiculo = TipoVehiculo.Moto;
            TipoIva iba = TipoIva.Electrico;
            */

            //Variables:
            TipoVehiculo vehiculo = TipoVehiculo.Moto;
            TipoIva iva = TipoIva.Electrico;

            //Precios normales:
            double pMoto = 1500;
            double pFurgoneta = 5000;
            double pCoche = 15000;

            string pedido;

            //Presento:
            Console.WriteLine("¡¡Bienvenido a Vehiculum!!");
            Console.WriteLine("¿Que tipo de vehiculo busca?");
            Console.WriteLine($"Tenemos: {vehiculo}, Coches, furgonetas...");

            //Tipo de vehiculo:
            pedido = "";
            while (pedido == "")
            {
                pedido = Console.ReadLine();

                switch (pedido)
                {
                    case "moto":
                        vehiculo = TipoVehiculo.Moto;
                        break;

                    case "coche":
                        vehiculo = TipoVehiculo.Coche;
                        break;

                    case "furgoneta":
                        vehiculo = TipoVehiculo.Furgoneta;
                        break;

                    default:
                        Console.WriteLine("Lo siento, ese tipo de vehiculo no lo tenemos");
                        Console.WriteLine("¿No prefiere alguno de los otros tipos?");
                        pedido = "";
                        break;
                }
            }

            Console.WriteLine($"Conque {vehiculo}, es muy buena eleccion");
            Console.WriteLine("Tenemos modelos que funcionan con gasoil, hibridos y electricos");
            Console.WriteLine("¿Que es lo que buscas?");

            //Tipo de combustible:
            pedido = "";
            while (pedido == "")
            {
                pedido = Console.ReadLine();

                switch (pedido)
                {
                    case "gasoil":
                        iva = TipoIva.Gasoil;
                        break;

                    case "hibrido":
                        iva = TipoIva.Hibrido;
                        break;

                    case "electrico":
                        iva = TipoIva.Electrico;
                        break;

                    default:
                        Console.WriteLine("Lo siento, ese tipo de vehiculo no lo tenemos");
                        Console.WriteLine("¿No prefiere alguno de los otros tipos?");
                        pedido = "";
                        break;
                }
            }

            //Precio Final:
            //MOTO----------------
            if (vehiculo == TipoVehiculo.Moto)
            {
                if (iva == TipoIva.Gasoil)
                {
                    pMoto += 315;
                    Console.WriteLine($"El precio final asciende a: {pMoto}");
                }

                else if (iva == TipoIva.Hibrido)
                {
                    pMoto += 150;
                    Console.WriteLine($"El precio final asciende a: {pMoto}");
                }

                else if (iva == TipoIva.Electrico)
                {
                    pMoto += 60;
                    Console.WriteLine($"El precio final asciende a: {pMoto}");
                }
            }

            //FURGONETA--------------------
            else if (vehiculo == TipoVehiculo.Furgoneta)
            {
                if (iva == TipoIva.Gasoil)
                {
                    pFurgoneta += 1050;
                    Console.WriteLine($"El precio final asciende a: {pFurgoneta}");
                }

                else if (iva == TipoIva.Hibrido)
                {
                    pFurgoneta += 500;
                    Console.WriteLine($"El precio final asciende a: {pFurgoneta}");
                }

                else if (iva == TipoIva.Electrico)
                {
                    pFurgoneta += 200;
                    Console.WriteLine($"El precio final asciende a: {pFurgoneta}");
                }
            }

            //COCHE--------------------------
            else if (vehiculo == TipoVehiculo.Coche)
            {
                if (iva == TipoIva.Gasoil)
                {
                    pCoche += 3150;
                    Console.WriteLine($"El precio final asciende a: {pCoche}");
                }

                else if (iva == TipoIva.Hibrido)
                {
                    pCoche += 1500;
                    Console.WriteLine($"El precio final asciende a: {pCoche}");
                }

                else if (iva == TipoIva.Electrico)
                {
                    pCoche += 600;
                    Console.WriteLine($"El precio final asciende a: {pCoche}");
                }
            }
        }
    }
}
