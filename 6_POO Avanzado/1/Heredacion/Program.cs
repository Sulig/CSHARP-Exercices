using System;

namespace Heredacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar dos estudiantes:
            Estudiant estudiante1 = new Estudiant("Sasha", "Dominguez", 50, 171, Genere.Femeni);
            Estudiant estudiante2 = new Estudiant("Julio", "Colque", 50, 172, Genere.Masculi);

            //Saludar, estudiar 4 veces, comer y volver a estudiar:
            estudiante1.Saluda();
            estudiante1.Estudia();
            estudiante1.Estudia();
            estudiante1.Estudia();
            estudiante1.Estudia();
            estudiante1.Menja();
            estudiante1.Estudia();
        }
    }
}