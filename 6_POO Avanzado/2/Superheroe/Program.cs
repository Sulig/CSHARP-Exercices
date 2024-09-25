using System;

namespace Superheroe
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHeroi batman = new SuperHeroi("Bruss", "Wein", 78, 175, "Batman");
            SuperHeroi superman = new SuperHeroi("Clark", "Joseph Kent", 68, 170, "Superman");
            Console.WriteLine("La fuerza de batman es: " + batman.forca);
            Console.WriteLine("La fuerza de superman es: " + superman.forca);

            batman.Menja();
            superman.Menja();

            Console.WriteLine("La fuerza de batman, despues de comer es: " + batman.forca);
            Console.WriteLine("La fuerza de superman, despues de comer es: " + superman.forca);
        }
    }
}