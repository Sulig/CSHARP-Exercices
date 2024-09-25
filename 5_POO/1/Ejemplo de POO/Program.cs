using System;

namespace Ejemplo_de_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear instncias de Beguda:
            Beguda bebidaA = new Beguda("Cocacola", 33, 1.5f);
            Beguda bebidaB = new Beguda("Fanta", 25, 1.2f);
            Beguda bebidaC = new Beguda("Nestea", 35, 1.3f);

            //Mostrar por pantalla:
            Console.WriteLine(bebidaA.ToString());
            Console.WriteLine(bebidaB.ToString());
            Console.WriteLine(bebidaC.ToString());

            //Vaciar la segunda bebida:
            bebidaB.Buidar();

            //Mostrar por pantalla:
            Console.WriteLine(bebidaA.ToString());
            Console.WriteLine(bebidaB.ToString());
            Console.WriteLine(bebidaC.ToString());

        }
    }
}