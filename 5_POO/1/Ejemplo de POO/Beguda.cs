using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_de_POO
{
    class Beguda
    {
        //Para el simbolo del €, *Ver "Simbologia* Dentro de la carpeta de bliblioteca de scripts -> 1_Aplicaciones de consola y utilizables -> SimbolosEspeciales
        //Declarar las variables de la classe: 
        public string nom;
        public int cl;
        public float preu;
        public int contingut;
        public DateTime dataCaducitat = DateTime.Now;

        public Beguda()
        {

        }

        //Metodo para simplificar la creacion de bebidas:
        public Beguda(string nom, int cl, float preu)
        {
            this.nom = nom;
            this.cl = cl;
            this.preu = preu;
            Omplir(); //Llama a la funcion Omplir y realiza su accion (llenar la bebida)
        }

        //Pasa la variable a string
        public override string ToString() //override -> sobreescribe, envez de lo que hace normalmente .ToString, hacemos otro metodo:
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Funcion para imprimir en console simbolos especiales.
            return $"{nom}, val {preu}€,conté {contingut}cl.";
        }

        //Funcion que llena la bebida al tope
        public void Omplir()
        {
            contingut = cl;
        }

        //Funcion que vacia la bebida a cero
        public void Buidar()
        {
            contingut = 0;
        }
    }
}