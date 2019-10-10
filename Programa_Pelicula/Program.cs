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
     public string Gettitulo( )
     {
        return this.titulo;
     }
     public void Setanio( int anio )
     {
        this.anio = anio;
     } 
     public int Getanio( )
     {
        return this.anio;
     }
   
      public Pelicula ()
      {

      }
            public Pelicula (string titulo, int anio)
      {
         this.titulo = titulo;
         this.anio = anio;
      }
      
      public void imprime()
      {
       Console.WriteLine("titulo: {0}\n Anio: {1}\n", this.titulo, this.anio);
      //Console.WriteLine(this.titulo, this.anio);
      }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1. Settitulo ( "Black Phanter" ) ;
            p1.Setanio  ( 2018 ) ;
           // Console.WriteLine("titulo: {0}\n Anio: {1}\n", p1.Gettitulo(), p1.Getanio());

            p1.imprime ();

            Pelicula p2 = new Pelicula();
            p2.Settitulo  (" MAD MAX " ) ;
            p2.Setanio  ( 1979 ) ;
           // Console.WriteLine("titulo: {0}\n Anio: {1}\n", p2.Gettitulo(), p2.Getanio());

            p2.imprime();

        }
    }
}
