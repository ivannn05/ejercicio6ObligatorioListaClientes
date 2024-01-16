using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ObligatorioListaClientes.Dtos
{
    internal class ClientesDtos
    {
        //Atributos
        long idCliente;

        string nombreCliente="aaaa";
        string apellidosCliente = "aaaa";
        string nombreCompletoCliente = "aaaa";
        int edad=1111;

        //Constructor
        public ClientesDtos(long idCliente, string nombreCliente, string apellidosCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCliente+apellidosCliente;
            this.edad = edad;
        }
        //Geters Y Seters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }

        public ClientesDtos()
        {
        }


    }
}
