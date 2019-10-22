using System;
//using System.Collections.Generic;
namespace Producto
{
    //producto:codigo,nombre,descripcion,precio list
    class Producto
    {
        private string nombre;
       /*  private Int16 codigo;
        private string descripcion;
        private int precio;*/

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
        /*public Int16 Codigo 
        {
            get
            {
                return codigo;
            }
            set 
            {
                codigo = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set 
            {
                descripcion = value;
            }
        }
        public int Precio
        {
            get
            {
                return precio;
            }
            set 
            {
                precio = value;
            }
        }*/
         public void setnombre(string nombre)
        {
            //hace referencia a este titulo publico = a titulo privado(osea que se trabaja
            //este dato privado en otras clases)
            this.nombre = nombre;
        }

        //1.3 el metodo getTitulo regresa el valor de this.Titulo para poder utilizarlo
        public string getnombre()
        {
            return this.nombre;
        }
        public Producto(string nombre// , Int16 codigo, string descripcion, int precio*/)
        {
            this.nombre = nombre;
           // this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;*/
        }
        public void print()
        {
            Console.WriteLine(nombre);
            //Console.WriteLine(codigo);
            Console.WriteLine(descripcion);
            Console.WriteLine(precio);*/
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {   
            Producto p1 = new Producto ("Producto: Queso\nCodigo: 15524529\nDescripcion: monterrey\nPrecio: $25");
            //p1.nombre = "Producto: Queso\nCodigo: 15524529\nDescripcion: monterrey\nPrecio: $25";
            //p1.codigo = "12556325";
            p1.descripcion = "Queso moterrey";
            p1.precio = "$24.00";*/
            p1.print();
            
        }
    }
}