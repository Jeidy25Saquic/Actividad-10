using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronicos
{
    public  class Producto
    {
        public List<string> Nombres { get; set; }=new List<string>();
        public List<string> Ids { get; set; } = new List<string>();
        public List<string> Stocks { get; set; } = new List<string>();

        int posicion;
        public bool BuscarProducto(string nombre)
        {  bool existe=false;
            for (int i = 0; i < Nombres.Count; i++)
            {
                if (Nombres[i] == nombre)
                {
                    posicion = i;
                    existe = true;
                    break;
                }
            }
            
            if (existe==false)
            {
                Console.WriteLine("No existe");
            }
  return  existe;
            

         
        }
         
        public int Posicion()
        {
            return posicion;
        }

        public void MostrarProducto()
        {

           
            foreach(string nombre in Nombres)
            {
                Console.WriteLine(nombre);
            }

        }


    }
}
