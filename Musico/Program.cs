using System;
using System.Collections.Generic;

namespace Musico
{
    class Musico
    {
        protected string nombre;

        public Musico(string n)
        {
            nombre = n;
        }
        public void Saluda()
        {
            Console.WriteLine("Hola, soy {0}", nombre);
        }
        public void Afina()
        {
            Console.WriteLine("{0}, afina su instrumento", nombre);
        }

    }
    class Bajista:Musico
    {
        private string bajo;
        public Bajista (string no, string bajo):base(no)
        {
            this.bajo = bajo;
        }
        public void Afina()
        {
            Console.WriteLine("{0}, afina su bajo {1}", nombre, bajo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico tom = new Musico("Tom");
            Bajista flea = new Bajista("Flea", "Gibson");
            tom.Saluda();
            flea.Saluda();
            tom.Afina();
            flea.Afina();
        }
    }
}
