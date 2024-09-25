using System;
using System.Collections.Generic;

namespace Harry_Potta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable:
            string cosa;
            
            //Lista:
            List<string> inventario = new List<string>() { "Glasses", "Tie", "Broom Strick", "Magic Wand" };

            //Mostrar toda la lista:
            Console.WriteLine(String.Join(", ", inventario));  //Para ver la lista

            //Modificar algo:
            Console.WriteLine("Quieres modificar algo?");
            cosa = Console.ReadLine();

            while (cosa == "si")
            {
                //Eliminar
                Console.WriteLine("Que cosa?, *Escribe el nombre*");
                cosa = Console.ReadLine();

                inventario.Remove(cosa);

                //Cambiar:
                Console.WriteLine("Pon lo que quieres que se muestre");
                cosa = Console.ReadLine();

                inventario.Add(cosa); //Para añadir algo a la lista

                //Mostrar toda la lista:
                Console.WriteLine(String.Join(", ", inventario));  //Para ver la lista

                //Modificar algo:
                Console.WriteLine("Quieres modificar algo mas?");
                cosa = Console.ReadLine();
            }
        }
    }
}
