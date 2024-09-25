using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbolosEspeciales
{
    public class Simbologia
    {
        /// <summary>
        /// Retorna un simbolo para poderlo usar en console:
        /// Console.OutputEncoding = System.Text.Encoding.UTF8;
        /// System.Console.Out.WriteLine("Simbolo especial");
        /// 
        /// *Para otros simbolos:
        /// \u00A3 is the Pound sign, £.
        /// \u00A9 is the copyright symbol, ©.
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static string Simbolos(string pedido)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            string salida = $"{Console.OutputEncoding = System.Text.Encoding.UTF8}";
            salida = $"{pedido}";
            return salida;
        }
    }
}