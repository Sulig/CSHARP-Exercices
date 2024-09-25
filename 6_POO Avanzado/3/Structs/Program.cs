using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiant estudiante1 = new Estudiant("Sasha", "Dominguez", 50, 170, Genere.Femeni, 21, 7, 2002);
            Console.WriteLine("Yo he nacido el: " + estudiante1.naixement);

            //Libro1:
            Llibre libro1 = new Llibre("Las aventuras de Alicia en el país de las maravillas",
                "Autor: Carroll, Lewis. Genero: Ensueño, Novela",
                "una niña llamada Alicia cae por un agujero, encontrándose en un mundo peculiar y extraño , poblado por humanos y criaturas antropomórficas.",
                "O el pozo era en verdad muy profundo, o ella caía muy despacio.");

            //Libro2:
            Llibre libro2 = new Llibre("Xènia tens un whatsapp",
                "Autor: Gemma Pasqual. Genero: Juvenil",
                "La Xènia ho fa. Mira la pantalla totalment hipnotitzada. L'aparell li indica que en Carles està en línia. Espera impacient perquè aparegui a la part superior de la pantalla el gerundi del verb escriure.",
                "Hola :D, XD");

            //Libro3:
            Llibre libro3 = new Llibre("Don Quijote de la Mancha",
                "Autor:  Miguel de Cervantes Saavedra",
                "Prosiguió su camino, sin llevar otro que aquel que su caballo quería, creyendo que en aquello consistía la fuerza de las aventuras",
                "En un lugar de la Mancha, de cuyo nombre no quiero acordarme, no ha mucho tiempo que vivía un hidalgo de los de lanza en astillero, adarga antigua, rocín flaco y galgo corredor.");

            //Añadir a la lista:
            estudiante1.llibres.Add(libro1);
            estudiante1.llibres.Add(libro2);
            estudiante1.llibres.Add(libro3);

            estudiante1.llibres[0].Biografia();
            estudiante1.llibres[1].Resumen();
            estudiante1.llibres[2].Leer();
        }
    }
}