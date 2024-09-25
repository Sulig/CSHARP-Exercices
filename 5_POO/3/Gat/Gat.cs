using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat
{
    //Enumerables de raza y genero del gato
    enum Raza {Siames, Persa, PeloCorto, AzulRuso, MaineCoon, Bengali}
    enum Genero {Macho, Hembra}

    class Gat
    {
        //Variables publicas:
        public string nombre;
        public Raza raza;
        public Genero genero;
        public float peso;
        public float altura;
        public int salud = 10;
        public int saciedad = 5;
        public int suenno = 5;


        public Gat()
        {

        }

        public Gat(string nombre, Raza raza, Genero genero, float peso, float altura)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.genero = genero;
            this.peso = peso;
            this.altura = altura;
            this.genero = genero;
        }

        public float CalculaIMC()
        {
            float imc = peso / (altura * altura);
            imc *= 10000;
            return imc;
        }

        public void Come()
        {
            if (saciedad > 10)
            {
                saciedad += 3;
            }

            else
            {
                peso++;
                salud--;
            }
        }

        public void Duerme()
        {
            suenno += 2;
        }

        public void Juega()
        {
            if(suenno < 2)
            {
                Console.WriteLine("No puede juagar, esta cansado");
            }

            else
            {
                suenno -= 2;
                peso -= 2;
            }
        }

        public void Estado()
        {
            //Variable salud que indica si es mala-regular-buena
            string salud = "";

            if(this.salud >= 1 && this.salud <=3)
            {
                salud = "Mala";
            }

            else if (this.salud >= 4 && this.salud <= 7)
            {
                salud = "Regular";
            }

            else if (this.salud >= 8 && this.salud <= 10)
            {
                salud = "Buena";
            }

            if (this.salud != 0)
            {
                Console.WriteLine($"{nombre} tiene un peso de {peso}, actualente su IMC es {CalculaIMC()}, tiene {suenno} de energia y su salud es {salud}");
            }

            else
            {
                Console.WriteLine($"Desgraciadamente, {nombre} ha fallecido");
            }
        }
    }
}