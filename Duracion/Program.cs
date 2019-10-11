using System;

namespace Duracion
{
    class Duracion
    {
        private int Horas;
        private int Minutos;
        private int Segundos;

        public Duracion(int Horas, int Minutos, int Segundos)
        {
            this.Horas = Horas;
            this.Minutos = Minutos;
            this.Segundos = Segundos;
        }
        public void imprime()
        {
            Console.WriteLine("Horas: {0}\nMinutos: {1}\nSegundos: {2}", this.Horas, this.Minutos, this.Segundos);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Duracion D = new Duracion(2,30,0);
            D.imprime();
        }
    }
}
