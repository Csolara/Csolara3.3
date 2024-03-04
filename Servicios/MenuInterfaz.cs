using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara3.Servicios
{
    /// <summary>
    /// Interfaz que se encarga del menu de la aplicación.
    /// CSL - 040324
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menu de la aplicación por pantalla y recoge la opcion seleccionada por el usuario.
        /// CSL - 040324
        /// </summary>
        /// <returns></returns>
        public int MENU();

        /// <summary>
        /// Método que muestra el menu del empleado por pantalla y recoge la opcion seleccionada por el usuario.
        /// CSL - 040324
        /// </summary>
        /// <returns></returns>
        public int EMPLEADO();

        /// <summary>
        /// Método que muestra el menu de la gerencia por pantalla y recoge la opcion seleccionada por el usuario.
        /// CSL - 040324
        /// </summary>
        /// <returns></returns>
        public int GERENCIA();

    }
}
