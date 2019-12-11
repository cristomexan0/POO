using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

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
       public static void EscribeProductoBIN(string DB, List<Producto> productos )
       {
           FileStream fs = new FileStream(DB, FileMode.OpenOrCreate, FileAccess.Write);
           BinaryWriter binOut = new BinaryWriter(fs);
           foreach(Producto p in productos)
           {
               binOut.Write(p.Codigo);
               binOut.Write(p.Descripcion);
               binOut.Write(p.Precio);
               binOut.Write(p.Departamento);
               binOut.Write(p.Likes);
           }
           binOut.Close();
       }

       public static void EscribeProductosTXT(string DB, List<Producto> productos)
       {
           FileStream fs = new FileStream(DB, FileMode.OpenOrCreate, FileAccess.Write);
           StreamWriter txtOut = new StreamWriter(fs);
           foreach(Producto p in productos)
           {
               txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
           }
           txtOut.Close();
       }

       public static List<Producto> LeeProductosBIN(string DB)
       {
           List<Producto> productos = new List<Producto>();
           FileStream fs = new FileStream(DB, FileMode.Open, FileAccess.Read);

           using ( BinaryReader binIn = new BinaryReader(fs))
           {
               while(binIn.PeekChar() !=1 )
               {
                   Producto producto = new Producto();
                   producto.Codigo = binIn.ReadString();
                   producto.Descripcion = binIn.ReadString();
                   producto.Precio = binIn.ReadDouble();
                   producto.Departamento = binIn.ReadInt();
                   producto.Likes = binIn.ReadInt();
                   productos.Add( producto );
               }
           }
           return productos;
       }

       public static List<Producto> LeeProductosTXT( string DB)
       {
           List<Producto> productos = new List<Producto>();
           using ( StreamReader sr = new StreamReader(DB))
           {
               string line = "";
               while ( (line = sr.ReadLine()) != 0)
               {
                   string[] columnas = line.Split('|');
                   productos.Add( new Producto(columnas[0], columnas[1], Double.Parse( columnas[2]), columnas[3], columnas[4] ));
               }
           }
           return productos;
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("PROHI","VANS w2", 125.23d));
            productos.Add(new Producto("PROHI","NIKE w2", 150.55d));
            productos.Add(new Producto("PROHI","LACOSTE w2", 225.65d));
            productos.Add(new Producto("PROHI","GUCCI w2", 350.50d));
           
           IEnumerable<Producto> productoQuery =
           from p in productos
           where p.Precio > 100
           orderby p.Descripcion
           select p;

           IEnumerable<Producto> productoQuery2 = productos.Select(p => p).Where( p => p.precio > 100).OrderBy(p => p.descripcion);

           foreach ( Producto p in productoQuery)
           {
               Console.WriteLine(p.Descripcion + "");
           }

           foreach(Producto p in productos)
           {
               Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
           }

           var jsonString = JsonSerializer.Serialize(productos);
           File.WriteAllText("fileName.json", jsonString);
           Console.WriteLine(jsonString);
        }
    }
}
