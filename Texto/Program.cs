using System;

namespace Texto
{
    class Texto
    {
        public string texto;
        public Texto(string r)
        {
            texto = r;
        }
        public static Texto operator + (Texto t1 , Texto t2)
        {
            return new Texto (t1.texto + t2.texto);
        }
        public void print()
        {
            Console.WriteLine(texto);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Texto t1 = new Texto("Hola ");
            Texto t2 = new Texto("Mundo");
            Texto r =(t1 + t2);
            r.print();
        }
    }
}
