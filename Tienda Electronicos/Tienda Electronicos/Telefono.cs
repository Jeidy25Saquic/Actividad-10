using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronicos
{
    public class Telefono: Producto
    {

        public List<string> Gama { get; set; } = new List<string>();


        public void AgregarTelefono( string id, string nombre, string stock, string gama)
        {
            Ids.Add(id);
            Nombres.Add(nombre);
            Stocks.Add(stock);
            Gama.Add(gama);
        }

        public void PedirDatos()
        {
            Console.WriteLine("Nombre del Telefono:");
            string nombre = Console.ReadLine();
            string Id = "telefono";
            Console.WriteLine("Gama: Alta,Media,Baja");
            string gama = Console.ReadLine();
            Console.WriteLine("Stock");
            string stock = Console.ReadLine();
           AgregarTelefono(Id, nombre, stock, gama);
        }
        
         public void MostrarTelefono()
        {
            if (Ids[Posicion()] == "telefono")
            {
                Console.WriteLine("Producto:" + Ids[Posicion()]);
                Console.WriteLine("Nombre:" + Nombres[Posicion()]);
                Console.WriteLine("Gama:" + Gama[Posicion()]);
                Console.WriteLine("Stock:" + Stocks[Posicion()]);
            }
        }
       
       
        


    }
}
