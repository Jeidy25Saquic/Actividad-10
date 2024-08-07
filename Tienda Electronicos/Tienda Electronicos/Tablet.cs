using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronicos
{
    public  class Tablet: Producto
    {
        public List<string> Marca { get; set; } = new List<string>();
        public List<string> Gen { get; set; } = new List<string>();


        public void AgregarOrdenador(string id, string nombre, string stock, string marca, string gen)
        {
            Ids.Add(id);
            Nombres.Add(nombre);
            Stocks.Add(stock);
            Marca.Add(marca);
            Gen.Add(gen);
        }
        public void PedirDatos()
        {
            Console.WriteLine("Nombre del ordenador:");
            string nombre = Console.ReadLine();
            string id = "tablet";
            Console.WriteLine("Teclado: alambrico, inalambrico");
            string marca = Console.ReadLine();
            Console.WriteLine("Mouse: alambrico, inalambrico");
            string gen = Console.ReadLine();
            Console.WriteLine("Stock");
            string stock = Console.ReadLine();
            AgregarOrdenador(id, nombre, stock, marca, gen);

        }

        public void MostrarTablet()
        {
            if (Ids[Posicion()] == "tablet")
            {
                Console.WriteLine("Producto:" + Ids[Posicion()]);
                Console.WriteLine("Nombre:" + Nombres[Posicion()]);
                Console.WriteLine("Teclado:" + Marca[Posicion()]);
                Console.WriteLine("Teclado:" + Gen[Posicion()]);
                Console.WriteLine("Stock:" + Stocks[Posicion()]);
            }
        }


    }

}

