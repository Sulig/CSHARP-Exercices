using System;

namespace Utilidades
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 2;
            float d = 3.5f;
            string dS = d.ToString();

            Util.ConversionFloatAString(d);
        }
    }
}
