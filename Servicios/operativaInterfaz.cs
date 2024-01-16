using ejercicio6ObligatorioListaClientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ObligatorioListaClientes.Servicios
{
    /// <summary>
    /// Interfaz que contiene los metodos con las operaciones de los clientes
    /// <author>ilp - 190124</author>
    /// </summary>
    internal interface operativaInterfaz
    {
        public void anyadirNuevoCliente(List<ClientesDtos>listaClientes);

        public void ordenarClientes(List<ClientesDtos> listaClientes);
    }
}
