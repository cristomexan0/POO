using System;
using System.IO;
using System.Collections.Generic;
namespace CP
{
    class Producto
    {
     public string codigo;
     public string descripcion;
     public double precio;
     public string Departamento;
     public int Likes;

     public Producto(string c,string d,double p,string De,int Li)
     {
      this.codigo=c;
      this.descripcion=d;
      this.precio=p;
      this.Departamento=De;
      this.Likes=Li;
     }
     public Producto()
     {
     }
     
    }

    class ProductoDB
    {
    public static void ProductosTXTOut(string Datos,List<Producto> productos)
    {
        try
        {
         FileStream FileS1 = new FileStream(Datos, FileMode.OpenOrCreate, FileAccess.Write);
         StreamWriter TXTOut = new StreamWriter(FileS1);

             foreach (Producto p in productos)
             {
              TXTOut.WriteLine("{0}|{1}|{2}|{3}|{4}", p.codigo, p.descripcion, p.precio, p.Departamento, p.Likes);
              }
              TXTOut.Close();
        }
        catch(FileNotFoundException)
        {
        Console.Write("Archivo inexistente");
        }
        catch(DirectoryNotFoundException)
        {
        Console.Write("Directorio inexistente");
        }
        catch(IOException )
        {
        Console.Write("IOException");
        }
    }
    public static void ProductosBINOut(string Datos,List<Producto> productos)
    {   
        try
        {
         FileStream FileS2 = new FileStream(Datos, FileMode.OpenOrCreate, FileAccess.Write);
         BinaryWriter binOUT = new BinaryWriter(FileS2);
         foreach (Producto pBi in productos)
         {
          binOUT.Write(pBi.codigo);
          binOUT.Write(pBi.descripcion);
          binOUT.Write(pBi.precio);
          binOUT.Write(pBi.Departamento);
          binOUT.Write(pBi.Likes);
         }
         binOUT.Close();
        }
        catch (FileNotFoundException)
        {
        Console.Write("Archivo inexistente");
        }
        catch (DirectoryNotFoundException)
        {
        Console.Write("Directorio inexistente");
        }
        catch (IOException)
        {
        Console.Write("IOException");
        }  
    }


  public static List<Producto> ProductosTXTIn(string Datos)
    {  
    StreamReader TXTIn=new StreamReader(new FileStream(Datos,FileMode.Open,FileAccess.Read));
    List<Producto> productos =new List<Producto>();
      
    while (TXTIn.Peek()!= -1)
    {
       string row=TXTIn.ReadLine();
       string[] columna= row.Split('|');
       Producto producto =new Producto();
       producto.codigo= columna[0];
       producto.descripcion= columna[1];
       producto.precio= Convert.ToDouble(columna[2]);
       producto.Departamento= columna[3];
       producto.Likes=Convert.ToInt32(columna[4]);
       productos.Add(producto);
    }
    return productos;
    }
    public static List<Producto> ProductosBINIn(string Datos)
    {
    BinaryReader BINIn =new BinaryReader(new FileStream(Datos,FileMode.Open,FileAccess.Read));    
    List<Producto> productos =new List<Producto>();
    while (BINIn.PeekChar() != -1)
    {
        Producto producto =new Producto();
    producto.codigo= BINIn.ReadString();
    producto.descripcion= BINIn.ReadString();
    producto.precio= BINIn.ReadDouble();
    producto.Departamento= BINIn.ReadString();
    producto.Likes= BINIn.ReadInt32();
    productos.Add(producto);
    } 

    BINIn.Close();
    return productos;
    }
    
    public static void GetDepartment()
    {
     string Eleccion = Console.ReadLine();
     int DEPO=Convert.ToInt32(Eleccion);
    
     switch (DEPO)
     {
      case 1:
       Console.WriteLine(" 1 | Libreta Roja | 71.99 | Departamento 1 | 13 Likes ");
      break;

      case 2:
       Console.WriteLine(" 2 | Paquete de lapices #3 | 85.99 | Departamento 2 | 23 Likes");      
      break;

      case 3:
       Console.WriteLine(" 3 | Lapiecera 3000 | 90.50 | Departamento 3 | 35 Likes ");
      break;

      case 4:
       Console.WriteLine(" 4 | Borradores Bicolor | 105.99 | Departamento 4 | 65 Likes");
      break;

      case 5:
       Console.WriteLine("Salir");
      break;

      default:
      Console.WriteLine("Final de la lista");
      break;
      
     }
   
    }

    }

    class Program
    {
        static void Main(string[] args)
        {
        List<Producto> productos =new List<Producto>();
        productos.Add(new Producto("1","Libreta Roja", 71.99d, "Departamento 1", 13));
        productos.Add(new Producto("2","Paquete de lapices #3" ,85.99d, "Departamento 2", 23));
        productos.Add(new Producto("3","Lapiecera 3000", 90.50d, "Departamento 3", 35));
        productos.Add(new Producto("4","Borradores Bicolor", 105.99d, "Departamento 4", 65));

        ProductoDB.ProductosBINOut(@"Producto.bin",productos);
        Console.WriteLine("\nDatos en archivo bin");
        Console.WriteLine("----------------------------");

        List<Producto> ProductosInB = ProductoDB.ProductosBINIn(@"Producto.bin");
        foreach(Producto Pb in ProductosInB)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} ",Pb.codigo,Pb.descripcion,Pb.precio,Pb.Departamento,Pb.Likes);
        }

        ProductoDB.ProductosTXTOut(@"Producto.txt", productos);
        Console.WriteLine("\nDatos en archivo txt");
        Console.WriteLine("-----------------------------");
        
        List<Producto> ProductoInt = ProductoDB.ProductosTXTIn(@"Producto.txt");
        foreach(Producto PT in ProductoInt)
        {
         Console.WriteLine("{0} {1} {2} {3} {4} ",PT.codigo,PT.descripcion,PT.precio,PT.Departamento,PT.Likes);
        }

        Console.WriteLine("\nElige un Departamento ");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Departamento 1");
        Console.WriteLine("Departamento 2");
        Console.WriteLine("Departamento 3");
        Console.WriteLine("Departamento 4");

        ProductoDB.GetDepartment();

        Console.ReadKey();

        }
    }
}