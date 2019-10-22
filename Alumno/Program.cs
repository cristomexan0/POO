using System;
//using System.Collections.Generic;
namespace Alumno
{    //alumno:#control,nombre,apellido,correo

    class Alumno 
    {
        private string nombre;
        //private Int16 N_control;

        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set 
            {
                nombre = value;
            }
        }
        /*public Int32 N_control
        {
            get 
            {
                return N_control;
            }
            set
            {
                N_control = value;
            }
        }*/
        public Alumno(string nombre/* , Int32 N_control*/)
        {
            this.nombre = nombre;
            /*this.N_control = N_control;*/
        
        }
        /*public Alumno1(Int32 N_control)
        {
            this.N_control = N_control;
        }*/
        public void print()
        {
            Console.WriteLine(nombre);
            //Console.WriteLine(N_control);
        }
        
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Nombre del alumno: Pepe\nApellido: Zanches\nNumero de control: 245764\nCorreo electronico: jolo@gmail.com");
            //N_control b = new N_control("{1}122554");
           // Console.WriteLine(p.Nombre);  
           a1.print();
           /*b.print();
           //List<Alumno> grupo = new List<Alumno>();
           grupo.Add(a1);
           foreach(Alumno m in grupo)
            {
                m.Alumno;
            }*/
        }
    }
}