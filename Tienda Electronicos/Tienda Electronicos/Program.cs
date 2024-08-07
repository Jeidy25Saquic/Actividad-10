using Tienda_Electronicos;

class Program
{
  

    static void Main(string[] args)
    {
        
       Producto producto = new Producto();
        Telefono telefono = new Telefono();
        Ordenador ordenador = new Ordenador();
        Tablet tablet = new Tablet();


        bool continuar = true;
        int opcion = 0;
       



        do
        {
            try
            {
                Console.WriteLine(" Electronica: ");
                Console.WriteLine("1. Ingresar  producto");
                Console.WriteLine("2. lista de productos  ");
                Console.WriteLine("3. buscar  producto");
                Console.WriteLine("4. salir");



                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Valor no esta en el rango...")
                        ; Console.WriteLine("Ingrese un valor: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:

                        switch (Agregar())
                        {
                            case 1:
                                telefono.PedirDatos();
                                break;
                            case 2:
                                ordenador.PedirDatos();
                                break;
                            case 3:
                                tablet.PedirDatos();
                                break;

                        }

                        break;

                    case 2:
                        Console.WriteLine("Productos Disponibles");
                        telefono.MostrarProducto();
                        ordenador.MostrarProducto();
                        tablet.MostrarProducto();


                        break;
                    case 3:
                        Console.WriteLine("Nombre del producto:");
                        string name= Console.ReadLine();
                        if (producto.BuscarProducto(name) == true)
                        {
                            telefono.MostrarTelefono();
                            ordenador.MostrarOrdenador();
                            tablet.MostrarTablet();
                           
                        }
                        break;
                    case 4:

                        continuar = false;

                        break;




                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error... " + ex.Message);

            }


        } while (continuar == true);


    }

    public static  int Agregar()
    {
        int opcion = 0;
        do
        {
            try
            {
                Console.Clear();
                Console.WriteLine(" Productos: ");
                Console.WriteLine("1. Telefono ");
                Console.WriteLine("2. Tablet ");
                Console.WriteLine("3. Ordenador ");
               opcion= Convert.ToInt32(Console.ReadLine());
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error... " + ex.Message);
            }
        } while (opcion < 1 || opcion > 4);
        return opcion;
    }
        
    
        
}