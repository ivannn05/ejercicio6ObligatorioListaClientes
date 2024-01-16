using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ObligatorioListaClientes.Servicios
{
    /// <summary>
    /// Implementacion donde contiene los metodos del menu pricipal 
    /// <author>ilp - 190124</author>
    /// </summary>
    internal class menuImplementacion : menuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionSeleccionada;
            Console.WriteLine("############################");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Dar alta de nuevo cliente");
            Console.WriteLine("2.Ordenar lista clientes");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("############################");  
            opcionSeleccionada= Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;

        }
    }
}
