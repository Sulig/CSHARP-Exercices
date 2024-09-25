using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroe
{
    class SuperHeroi : Persona
    {
        //Variables publicas de superheroi:
        public string superNom;
        public int forca;
        private static int forca_Max = 25;

        //Constructores:
        public SuperHeroi() { }

        public SuperHeroi(string nom, string cognoms, float pes, float alcada, string superNom)
        {
            this.nom = nom;
            this.cognoms = cognoms;
            this.pes = pes;
            this.alcada = alcada;
            this.superNom = superNom;
        }

        public override void Menja()
        {
            base.Menja();
            IncrementaForca();
        }

        private void IncrementaForca()
        {
            forca++;
        }
    }
}