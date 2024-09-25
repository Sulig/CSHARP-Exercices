using System;

namespace Matriz_de_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES:
            string respuesta = "";
            int pose;

            //Matriz de elementos:
            string[] obj = new String[] { "Glasses", "Tie", "BroomStick", "Magic Wand" };

            //Mostrar todo el contenido con String.Join. ->
            Console.WriteLine(String.Join(", ", obj));  //Para ver la lista

            //Preguntar si el usuario quiere cambiar algo:
            Console.WriteLine("Wanna change something?");
            respuesta = Console.ReadLine();

            switch (respuesta)
            {
                case "Yes":
                    respuesta = "Si";
                    break;

                case "YES":
                    respuesta = "Si";
                    break;

                case "yes":
                    respuesta = "Si";
                    break;

                case "Y":
                    respuesta = "Si";
                    break;

                case "Yeah":
                    respuesta = "Si";
                    break;

                case "y":
                    respuesta = "Si";
                    break;

                default:
                    respuesta = "No";
                    break;
            }

            while (respuesta == "Si")
            {
                //Que pose?
                Console.WriteLine("What pose?");
                pose = int.Parse(Console.ReadLine());
                pose--;

                //Cambiar //palabra de la pose// por:
                Console.WriteLine($"Change {obj[pose]} for: ");
                obj[pose] = Console.ReadLine();

                //El nuevo cambio:
                Console.WriteLine($"The new list is:");
                Console.WriteLine(String.Join(", ", obj));  //Para ver la lista

                //Quieres hacer algo mas?
                Console.WriteLine("Wanna change something more?");
                respuesta = Console.ReadLine();

                switch (respuesta)
                {
                    case "Yes":
                        respuesta = "Si";
                        break;

                    case "YES":
                        respuesta = "Si";
                        break;

                    case "yes":
                        respuesta = "Si";
                        break;

                    case "Y":
                        respuesta = "Si";
                        break;

                    case "y":
                        respuesta = "Si";
                        break;

                    case "Yeah":
                        respuesta = "Si";
                        break;

                    default:
                        respuesta = "No";
                        break;
                }
            }
        }
    }
}