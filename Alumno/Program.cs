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
            Alumno a1 = new Alumno("Nombre del alumno: Pepe\nApellido: Zanches\nNumero de control: 245764\nCorreo electronico: PpZnchs@gmail.com\n\n");
            //N_control b = new N_control("{1}245764");
           // Console.WriteLine(p.Nombre);  
           a1.print();

           Alumno a2 = new Alumno("Nombre del alumno: Poncho\nApellido: Tunas\nNumero de control: 365463\nCorreo electronico: PonchitoTun027@gmail.com\n\n");
            //N_control b = new N_control("{2}365463");
           // Console.WriteLine(p.Nombre);  
           a2.print();

           Alumno a3 = new Alumno("Nombre del alumno: Julio\nApellido: Zapata\nNumero de control: 876469\nCorreo electronico: JulionZapaton105@gmail.com\n");
            //N_control b = new N_control("{3}876469");
           // Console.WriteLine(p.Nombre);  
           a3.print();
           /*b.print();
           //List<Alumno> grupo = new List<Alumno>();
           grupo.Add(a1);
           foreach(Alumno m in grupo)
            {
                m.Alumno;
            }*/

           /*b.print();
           //List<Alumno> grupo = new List<Alumno>();
           grupo.Add(a2);
           foreach(Alumno m in grupo)
            {
                m.Alumno;
            }*/

           /*b.print();
           //List<Alumno> grupo = new List<Alumno>();
           grupo.Add(a3);
           foreach(Alumno m in grupo)
            {
                m.Alumno;
            }*/
        }
    }
}