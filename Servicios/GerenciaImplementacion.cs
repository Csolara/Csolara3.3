using Csolara3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara3.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de la gerencia.
    /// CSL - 040324
    /// </summary>
    internal class GerenciaImplementacion : GerenciaInterfaz
    {

        public void CrearPedido()
        {
            GerenciaDto listagerencia = new GerenciaDto();

            Console.WriteLine("Introduzca el nombre del producto:");
            listagerencia.NombreProducto1 = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad:");
            listagerencia.Cantidad1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la fecha deseada de entrega(dd-MM-yyyy):");
            listagerencia.FechaEntrega1 = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("==================================");
            Console.WriteLine("Nombre: " + listagerencia.NombreProducto1);
            Console.WriteLine("Cantidad: " + listagerencia.Cantidad1);
            Console.WriteLine("Fecha de entrega: " + listagerencia.FechaEntrega1);
            Console.WriteLine("==================================");
            Console.WriteLine("");

        }

        public void VentasDia(List<GerenciaDto> listagerencia)
        {

        }
    }
}
