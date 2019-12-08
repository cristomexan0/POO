using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoHI
{
    public class Producto
    {
        public string Codigo { get; set ;}
        public string Descripcion { get ; set ;}
        public double Precio { get; set;}
        public int Departamento { get; set;}
        public int Likes { get; set;}

        public Producto(string c, string d, double p, int D, int L) 
        {
            Codigo = c; Descripcion = d; Precio = p; Departamento = D; Likes = L; 
        }
        public Producto()
        {}
       //GetDepartment(int Depto)

        /*  public void SetDepartamento( int Depto)
        {
            this.Depto = Depto;
        }
        public int GetDepartment()
        {
            return this.Departament;
        }*/
    }



    class ProductoDB
    {
       
    }




    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("PROHI","VANS", 125.23d));
            productos.Add(new Producto("PROHI","NIKE", 150.55d));
            productos.Add(new Producto("PROHI","LACOSTE", 225.65d));
            productos.Add(new Producto("PROHI","GUCCI", 350.50d));
           
        }
    }
}
