using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronicos
{
    public class Ordenador : Producto
    {
        public List<string> Teclado { get; set; } = new List<string>();
        public List<string> Mouse { get; set; } = new List<string>();


        public void AgregarOrdenador(string id, string nombre, string stock, string teclado, string mouse)
        {
            Ids.Add(id);
            Nombres.Add(nombre);
            Stocks.Add(stock);
            Teclado.Add(teclado);
             Mouse.Add(mouse);
        }
        public void PedirDatos() { 
        Console.WriteLine("Nombre del ordenador:");
                                 string nombre = Console.ReadLine();
        string id = "ordenador";
        Console.WriteLine("Teclado: alambrico, inalambrico");
                                string teclado = Console.ReadLine();
        Console.WriteLine("Mouse: alambrico, inalambrico");
                                string mouse = Console.ReadLine();
        Console.WriteLine("Stock");
                                string stock = Console.ReadLine();
        AgregarOrdenador(id, nombre, stock, teclado, mouse);

            }

        public void MostrarOrdenador()
        {
            if (Ids[Posicion()] == "ordenador")
            {
                Console.WriteLine("Producto:" + Ids[Posicion()]);
                Console.WriteLine("Nombre:" + Nombres[Posicion()]);
                Console.WriteLine("Teclado:" + Teclado[Posicion()]);
                Console.WriteLine("Stock:" + Stocks[Posicion()]);
            }
        }


    }
}
