using Csolara3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara3.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa del empleado.
    /// CSL - 040324
    /// </summary>
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// Método que se encarga de añadir una nueva venta con los datos que ha introducido el usuario.
        /// CSL - 040324
        /// </summary>
        /// <param name="listaempleados"></param>
        public void AñadirVenta(List<EmpleadoDto> listaempleados);

        /// <summary>
        /// Método que se encarga de calcular y mostrar por pantalla el calculo de ventas diario.
        /// CSL - 040324
        /// </summary>
        /// <param name="listaempleados"></param>
        public void CalculoVentasDiario(List<EmpleadoDto> listaempleados);

    }
}
