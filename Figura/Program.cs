using System;
using Sytem.Collections.Generic;
namespace Figura
{
    abstract
    class Figura
    {
        protected int ancho, alto;
        protected int px, py;
        protected string color_relleno, color_borde;

        //creamos un constructor
        public Figura(int ancho, int alto, int px, int py, string color_borde, string color_relleno)
        {
            
        }
     //se implementa abstract para....
        public abstract void dibuja();
        {
            
        }
    }

    class Rectangulo:Figura
    {
        public Resctangulo(int ancho):base(int ancho)
        {

        }
        public override void dibuja()
        {
            Console.WriteLine("se dibuja un rect color {0} en x:{1} y y:{2}", color_rellen, px, py);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Figura f = new Figura(10,10);
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Rectangulo(10,10));
        }
    }
}
