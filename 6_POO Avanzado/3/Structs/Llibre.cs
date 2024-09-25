using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Llibre : Estudiant
    {
        //Propiedades publicas:
        public string tituloLibro;
        public string biografia;
        public string resumenContraportada;
        public string parrafoImportante;


        //Constructores:
        public Llibre()
        {
            tituloLibro = "";
            biografia = "";
            resumenContraportada = "";
            parrafoImportante = "";
        }
        
        public Llibre(string titulo, string bibiografia, string resumen, string parrafo)
        {
            tituloLibro = titulo;
            this.biografia = bibiografia;
            resumenContraportada = resumen;
            parrafoImportante = parrafo;
        }

        //Funciones de libro:
        public void CojerLibro()
        {
            Console.WriteLine($"Cojes el libro <<{tituloLibro}>>");
        }

        public void DejarLibro()
        {
            Console.WriteLine($"Dejas el libro <<{tituloLibro}>> en la estanteria");
        }

        public void Biografia()
        {
            Console.WriteLine($"Lees la biografia del libro <<{tituloLibro}>>.");
            Console.WriteLine($"Pone: {biografia}");
        }

        public void Resumen()
        {
            Console.WriteLine($"Lees la contraportada del libro <<{tituloLibro}>>.");
            Console.WriteLine($"Pone: {resumenContraportada}");
        }

        public void Leer()
        {
            Console.WriteLine($"Lees un parrafo al azar del libro <<{tituloLibro}>>.");
            Console.WriteLine($"Pone: <<{parrafoImportante}>>");
        }
    }
}