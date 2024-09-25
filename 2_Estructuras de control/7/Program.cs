using System;

namespace Palabras_Palindromas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables:
            string palIntroducida, palInver = "";

            //Inroducir datos:
            Console.WriteLine("Introduce una palabra");
            palIntroducida = Console.ReadLine();

            //Por cada letra de palabra introducida, ponga la ultima letra en el primer puesto de palInver, y asi hasta llegar al final de palIntroducida
            for (int x = palIntroducida.Length - 1; x >= 0; x--)
            {
                palInver += palIntroducida[x];
            }


            //Comprobar si es o no una palabra palindroma, si lo es, palIntroducida sera igual a palInver:
            if (palIntroducida == palInver)
            {
                Console.WriteLine($"{palIntroducida} es una palabra palindroma");
            }

            else
            {
                Console.WriteLine($"{palIntroducida} no es una palabra palindroma");
            }
        }
    }
}
