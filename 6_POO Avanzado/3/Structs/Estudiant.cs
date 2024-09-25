using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Estudiant : Persona
    {
        //Variables publicas de estudiante:
        public int energia = 2;
        public static int energia_Max = 3;

        //Lista:
        public List<Llibre> llibres = new List<Llibre>();

        //Constructores:
        public Estudiant() {llibres = new List<Llibre>(); }

        public Estudiant(string nom, string cognoms, float pes, float alcada, Genere genere, int dia, int mes, int anno)
        {
            this.nom = nom;
            this.cognoms = cognoms;
            this.pes = pes;
            this.alcada = alcada;
            this.genere = genere;

            naixement = new DateTime(anno, mes, dia);
        }

        //Funciones de la clase:
        //Menja añadir:
        public override void Menja()
        {
            base.Menja();
            Console.WriteLine("ñam, qué bo!");
            energia = energia_Max;
        }

        //Saluda modificar:
        public override void Saluda()
        {
            Console.WriteLine($"¡Hola!, soy {nom}");
        }

        //Funcion Estudia:
        public void Estudia()
        {
            if (energia >= 1)
            {
                energia--;
                pes -= 0.1f;
                Console.WriteLine("estic estudiant");
            }

            else
            {
                Console.WriteLine("tinc gana, no puc estudiar");
            }
        }
    }
}