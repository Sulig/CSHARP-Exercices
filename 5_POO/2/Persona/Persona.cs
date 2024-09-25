using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    enum Genere {Hombre, Mujer};
    class Persona
    {
        //Declarar las variables de la classe: 
        public string nom;
        public string cognoms;
        public float pes;
        public float alcada;
        public Genere genere;

        public Persona()
        {

        }

        //Metodo para simplificar la creacion de bebidas:
        public Persona(string nom, string cognoms, float pes, float alcada, Genere genere)
        {
            this.nom = nom;
            this.cognoms = cognoms;
            this.pes = pes;
            this.alcada = alcada;
            this.genere = genere;
        }

        //Funcion que calcula el IMC
        public float CalculaIMC()
        {
            float imc = pes / (alcada * alcada);
            imc *= 10000;
            return imc;
        }

        public void Menja()
        {
            pes += 0.5f;
        }

        public void Corre()
        {
            DecrementaPes();
            
        }

        public void Saluda()
        {
            Console.WriteLine($"Hola, em dic {nom} {cognoms}");
        }

        private void DecrementaPes()
        {
            if (pes > 0)
            {
                pes -= 0.1f;
            }

            else if (pes < 0)
            {
                pes = 0;
            }
        }

    }
}