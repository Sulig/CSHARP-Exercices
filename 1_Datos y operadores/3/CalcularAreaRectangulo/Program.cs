using System;

namespace CalcularAreaRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este programa de "pruebas", se utilizara como un programa para calcular el area de un rectangulo.
            // 1ro, Declaramos las variables
            int bas = 0;
            int altura = 0;
            int area = 0;

            Console.WriteLine("Para calcular el área del rectangulo, necesitaré tú base y la altura");
            Console.WriteLine("Introduce el valor de la base");
            bas = int.Parse(Console.ReadLine());
            //*Parse se usa para que el valor introducido lo podamos usar dentro de el programa, si se introduce algo que no sea un valor, conducira a un error
            //*ReadLine, para introducir el valor del usuario 
            Console.WriteLine("Introduce el valor de la altura");
            altura = int.Parse(Console.ReadLine());
            area = bas * altura;
            Console.WriteLine("Tú área es: " + area);
            //* Dejo un espacio despues de : para que el valor "area" se introduzca allí
        }
    }
}
