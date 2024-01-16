using ejercicio6ObligatorioListaClientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ObligatorioListaClientes.Servicios
{/// <summary>
/// Implementacion donde estan los metodos que hacen las operaciones de los clientes
/// <author>ilp - 190124</author>
/// </summary>
    internal class operativaImplementacion : operativaInterfaz
    {
        /// <summary>
        /// Metodo que añade un nuevo cliente a la lista de clientes 
        /// <author>ilp - 190124</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public void anyadirNuevoCliente(List<ClientesDtos> listaClientes)
        {
            ClientesDtos cliente = darAltaCliente();
            listaClientes.Add(cliente);
        }
        /// <summary>
        /// Metodo que da de alta al nuevo cliente 
        /// <author>ilp - 190124</author>
        /// </summary>
        /// <returns></returns>
        private ClientesDtos darAltaCliente()
        {
            Console.WriteLine("Introduzca el id del cliente ");
            long IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del cliente ");
            string NombreCliente=Console.ReadLine();
            Console.WriteLine("Introduzca el apellido del cliente ");
            string ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la edad del cliente ");
            int Edad = Convert.ToInt32(Console.ReadLine());

            ClientesDtos cliente =new ClientesDtos(IdCliente,NombreCliente,ApellidosCliente,Edad);

            Console.WriteLine(cliente.NombreCliente+cliente.ApellidosCliente);
            return cliente;

        }
        /// <summary>
        /// Este meotodo ordena la lista de los clientes 
        /// <author>ilp - 190124</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public void ordenarClientes(List<ClientesDtos> listaClientes)
        {
           if(listaClientes.Count<3)
            {

                Console.WriteLine("Tiene que tener 3 clientes creados ");
            }
            else
            {
                Console.WriteLine("Ya hay 3 clientes ");

    
                for(int i = 0; i < listaClientes.Count; i++)
                {
                    Console.WriteLine(listaClientes[i].NombreCompletoCliente + listaClientes[i].Edad);
                    
                }

                 

                for (int i = 0; i < listaClientes.Count - 1; i++)
                {
                    for (int j = 0; j < listaClientes.Count - 1; j++)
                    {
                        if (listaClientes[j].Edad < listaClientes[j + 1].Edad)
                        {
                            ClientesDtos aux = listaClientes[j];
                            listaClientes[j] = listaClientes[j + 1];
                            listaClientes[j + 1] = aux;
                        }
                    }
                }

                Console.WriteLine("---------------");
                for (int i = 0; i < listaClientes.Count; i++)
                {
                    Console.WriteLine(listaClientes[i].NombreCompletoCliente + listaClientes[i].Edad);

                }


            }

        }


    }
}
