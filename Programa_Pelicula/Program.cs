using System;

namespace Programa_Pelicula
{
    class Pelicula
    {
        private string titulo;
        private int anio;
    
     public void Settitulo( string titulo )
     {
        this.titulo = titulo;
     }
     public void Gettitulo( )
     {
        return this.titulo;
     }
     public void Setanio( int anio )
     {
        this.anio = anio;
     } 
     public void Getanio( )
     {
        return this.anio;
     }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1. Settitulo ( "Black Phanter" ) ;
            p1.Setanio  ( 2018 ) ;
            Console.WriteLine("titulo: {0}\n Anio: {1}\n", p1.Gettitulo(), p1.Getanio());

            Pelicula p2 = new Pelicula();
            p2.Settitulo  (" MAD MAX " ) ;
            p2.Setanio  ( 1979 ) ;
            Console.WriteLine("titulo: {0}\n Anio: {1}\n", p2.Gettitulo(), p2.Getanio());

        }
    }
}
