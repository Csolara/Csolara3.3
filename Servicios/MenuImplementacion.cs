using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara3.Servicios
{
    /// <summary>
    /// Método que implementa la interfaz del menú.
    /// CSL - 040324
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int MENU()
        {
            int opcionseleccionada;

            Console.WriteLine("##########################");
            Console.WriteLine("0. Cerrar aplicación.");
            Console.WriteLine("1. Menú Empleado.");
            Console.WriteLine("2. Menú Gerencia.");
            Console.WriteLine("##########################");            

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionseleccionada;
        }

        public int EMPLEADO()
        {
            int opcionseleccionada;
            
            Console.WriteLine("#####################################");
            Console.WriteLine("0. Calculo total de ventas diario.");
            Console.WriteLine("1. Añadir venta.");
            Console.WriteLine("#####################################");

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionseleccionada;
        }

        public int GERENCIA()
        {
            int opcionseleccionada;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Ventas del dia.");
            Console.WriteLine("1. Crear pedido.");
            Console.WriteLine("#####################");

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionseleccionada;
        }
    }
}
