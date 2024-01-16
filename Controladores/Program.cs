using ejercicio6ObligatorioListaClientes.Dtos;
using ejercicio6ObligatorioListaClientes.Servicios;

namespace ejercicio6ObligatorioListaClientes;
class Program
{
    /// <summary>
    /// Metodo principal de la aplicacion , por la cual se lanzara el programa 
    /// <author>ilp - 190124</author>
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        List<ClientesDtos>listaClientes = new List<ClientesDtos>();
        menuInterfaz mi = new menuImplementacion();
        operativaInterfaz op = new operativaImplementacion();
        int opcion;

        bool cerrarMenu = false;


        while (!cerrarMenu)
        {
            opcion=mi.mostrarMenuYSeleccion();
            Console.WriteLine(opcion);
            switch (opcion)
            {
                case 0:
                    cerrarMenu=true;
                    Console.WriteLine("Se ha cerrado el menu");
                    break;
                case 1:
                    Console.WriteLine("Se añade un nuevo cliente ");
                    op.anyadirNuevoCliente(listaClientes);
                    foreach(ClientesDtos cliente in listaClientes)
                    {
                        Console.WriteLine(cliente.NombreCliente);
                    }
                    break;
                case 2:
                    Console.WriteLine("Se ordenaran los clientes ");
                    op.ordenarClientes(listaClientes);
                    break;

            }
        }
    }
}