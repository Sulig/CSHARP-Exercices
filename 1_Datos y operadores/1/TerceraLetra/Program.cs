using System;

namespace TerceraLetra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu palabra");
            string palabra = ""; //Aqui se guardara lo que el usuario ponga
            palabra = Console.ReadLine();  //Con esta funcion, el usuario puede introducir lo que quiera, a excepcion de numeros. *Ver programa de calcular area rectangulo.

            char terceraletra = palabra[2]; //Aqui es donde el programa lee lo que ha introducido el usuario y con [2] le estoy diciendo que coja la tercera letra
            // [0] para la primera, [1] para la segunda, y asi..
            // Entonces le muestro al usuario la tercera letra de su palabra. ->
            Console.WriteLine($"La tercera letra es: {terceraletra}. Que tengas un buen dia"); //* $ * Este es otro metodo para que se muestre lo que el usuario ha mostrado en un determinado lugar.
        }
    }
}
