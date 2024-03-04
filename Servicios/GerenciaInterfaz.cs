using Csolara3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara3.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa de la gerencia.
    /// CSL - 040324
    /// </summary>
    internal interface GerenciaInterfaz
    {
        /// <summary>
        /// Método que se encarga de crear un pedido segun los datos que haya introducido el usuario.
        /// CSL - 040324
        /// </summary>
        public void CrearPedido();

        /// <summary>
        /// Método que se encarga de mostrar las ventas del dia.
        /// CSL - 040324
        /// </summary>
        /// <param name="listagerencia"></param>
        public void VentasDia(List<GerenciaDto> listagerencia);

    }
}
