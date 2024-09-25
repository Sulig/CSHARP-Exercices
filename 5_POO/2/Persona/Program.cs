using System;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear instancias de Persona:
            Persona personaA = new Persona("Papa", "Noel", 95f, 165f, Genere.Hombre);
            personaA.Saluda();
            personaA.Menja();
            Console.WriteLine(personaA.CalculaIMC());
            personaA.Menja();
            personaA.Menja();
            personaA.Menja();
            Console.WriteLine(personaA.CalculaIMC());
        }
    }
}