using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    //Enumerable de genero:
    enum Genere { Masculi, Femeni, NoBinari }
    class Persona
    {
        //Propiedades publicas:
        public string nom;
        public string cognoms;
        public float pes;
        public float alcada;
        public Genere genere;
        public DateTime naixement;

        //Constructores:
        public Persona() //Valores por defecto:
        {
            nom = "Sin nombre";
            cognoms = "Sin apellidos";
            pes = 0f;
            alcada = 0f;
            genere = Genere.NoBinari;
            naixement = new DateTime(2022, 1, 1);
        }

        public Persona(string nom, string cognoms, float pes, float alcada, Genere genere, int dia, int mes, int anno)
        {
            this.nom = nom;
            this.cognoms = cognoms;
            this.pes = pes;
            this.alcada = alcada;
            this.genere = genere;

            naixement = new DateTime(anno, mes, dia);
        }

        //Finciones predefinidas:
        //Funcion calcula IMC
        public float CalculaIMC()
        {
            float imc = pes / MathF.Pow(alcada, 2); //Utilizacion de la utilidad MathF.Pow * Elevar *
            imc *= 10000;
            return imc;
        }

        //Funcion Come
        public virtual void Menja()
        {
            pes += 0.5f;
        }

        //Funcion Corre
        public void Corre()
        {
            DecrementaPes();
        }

        //Funcion Saluda
        public virtual void Saluda()
        {
            Console.WriteLine($"Saludos, soy {nom} {cognoms}");
        }

        //Funcion Disminuir peso
        protected void DecrementaPes() //Es protected porque solo se va a compartir con sus descendientes.
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