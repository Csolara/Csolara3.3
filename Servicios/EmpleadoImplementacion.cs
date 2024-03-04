using Csolara3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara3.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del empleado.
    /// CSL - 040324
    /// </summary>
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public void AñadirVenta(List<EmpleadoDto> listaempleados)
        {
            EmpleadoDto añadir = AV();
            listaempleados.Add(añadir);            
        }
        private EmpleadoDto AV()
        {
            EmpleadoDto listaempleados = new EmpleadoDto();
            
            Console.WriteLine("Introduzca el importe:");
            listaempleados.Importe = Console.ReadLine();            

            Console.WriteLine("");
            Console.WriteLine("===========================");
            Console.WriteLine("Importe: " + listaempleados.Importe);
            Console.WriteLine("Fecha: " + listaempleados.FechaVenta1);
            Console.WriteLine("ID: ");
            Console.WriteLine("===========================");
            Console.WriteLine("");

            return listaempleados;
        }       

        public long ID (List<EmpleadoDto> listaempleados)
        {
            long id;
            int tamaño = listaempleados.Count;
            if(tamaño > 0)
            {
                id = 1;
            }
            else
            {
                id = listaempleados[tamaño - 1].IdEmple + 1;
            }

            return id;
        }

        public void CalculoVentasDiario(List<EmpleadoDto> listaempleados)
        {

            if (listaempleados.Count > 0)
            {
                foreach(EmpleadoDto empleado in listaempleados)
                {
                    DateTime ahora = DateTime.Now;

                    listaempleados[0].Duracion1 = ahora - listaempleados[0].FechaVenta1;

                    Console.WriteLine("");
                    Console.WriteLine("============================");
                    Console.WriteLine("Total ventas: " + listaempleados.Count);
                    Console.WriteLine("Tiempo transcurrido: " + listaempleados[0].Duracion1);
                    Console.WriteLine("============================");
                    Console.WriteLine("");
                }
            }

        }
    }
}
