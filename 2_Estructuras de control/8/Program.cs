using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaSenars = 0;

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(sumaSenars);

                if (i % 2 != 0)
                {
                    sumaSenars += i;
                   // Console.WriteLine(sumaSenars);
                }
            } 
        }
    }
}
