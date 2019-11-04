using System;
using System.Collections.Generic:IComparable;
namespace Persona
{
    class Persona
    {
        int id;
        string nombre;
        public Persona(int id, string n)
        {
            this.id = id;
            nombre.n;
        }
        public override string ToString()
        {
            return string.format("{0}, {1}, id, nombre");
        }
        public int CompareTo(object o)
        {
            return int CompareTo(((Persona)o).id);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> pers = new List<Persona>;
            pers.Add(new Persona(2,"Pam"));
            pers.Add(new Persona(1("Kim"));
            pers.Add(new Persona(3("Mike"));
            pers.Sort();
            
            foreach(Persona p in pers)
            {
                Console.WriteLine(p);
            }
        }
    }
}
