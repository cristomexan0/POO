using System;

namespace Programa_Pelicula
{
    class Pelicula
    {
        private string titulo;
        private int anio;
        private string pais;
        private string director;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.titulo = "Black Phanter";
            p1.anio = 2018;
            p1.pais = "USA";
            p1.director = "Ryan Coogler";
            Console.WriteLine("titulo: {0}\nAnio: {1}\n", p1.titulo, p1.anio);
        }
    }
}
