using System;

namespace Mayor_y_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int array;

            Console.WriteLine("Introduce un numero limite para la coleccion");
            array = int.Parse(Console.ReadLine());

            float[] num = new float[array];
            int[] nums = new int[array];

            for (int x = 0; x < num.Length; x++)
            {
                Console.WriteLine($"Introduce el numero {x + 1}");
                num[x] = float.Parse(Console.ReadLine());
                nums[x] = (int)num[x];
            }

            Console.WriteLine("El numero mas grande es: " + MaxNumber(num));
            Console.WriteLine("(int) El numero mas grande es: " + MaxNumber(nums));
            Console.WriteLine("El numero mas pequeño es: " + MinNumber(num));
            Console.WriteLine("(int) El numero mas pequeño es: " + MinNumber(nums));
        }

        //Funcion que mira cual es el numero mas grande:

        //Tipo int:
        private static int MaxNumber(int[] nums)
        {
            int max = nums[0];

            //Mirar cual es la mas pequeña:
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = 0;
                    max += nums[i];
                }
            }

            return max;
        }

        //Tipo float:
        private static float MaxNumber(float[] num)
        {
            float max = 0;

            //Mirar cual es la mas pequeña:
            for (int i = 0; i < num.Length; i++)
            {
                if (max < num[i])
                {
                    max = 0;
                    max += num[i];
                }
            }

            return max;
        }

        //Funcion que mira cual es el numero mas pequeño:

        //Tipo int:
        private static int MinNumber(int[] nums)
        {
            int min = nums[0];

            //Mirar cual es la mas pequeña:
            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = 0;
                    min += nums[i];
                }
            }

            return min;
        }

        //Tipo Float
        private static float MinNumber(float[] num)
        {
            float min = num[0];

            //Mirar cual es la mas pequeña:
            for (int i = 0; i < num.Length; i++)
            {
                if (min > num[i])
                {
                    min = 0;
                    min += num[i];
                }
            }

            return min;
        }
    }
}