using Csolara3.Dtos;
using Csolara3.Servicios;

namespace Csolara3
{
    /// <summary>
    /// Clase principal de la aplicaión.
    /// CSL - 040324
    /// </summary>
    class program
    {
        /// <summary>
        /// Método principal de la aplicación.
        /// CSL - 040324
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            List<EmpleadoDto> listaempleados = new List<EmpleadoDto>();
            List<GerenciaDto> listagerencia = new List<GerenciaDto>();

            MenuInterfaz mi = new MenuImplementacion();
            EmpleadoInterfaz ei = new EmpleadoImplementacion();
            GerenciaInterfaz gi = new GerenciaImplementacion();

            bool cerrarMenu = false;

            while(!cerrarMenu)
            {
                int recogido = mi.MENU();
                switch(recogido)
                {
                    case 0:
                        Console.WriteLine("La aplicación se cerrara.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        int recogido2 = mi.EMPLEADO();
                        switch (recogido2)
                        {
                            case 0:
                                ei.CalculoVentasDiario(listaempleados);
                                break;
                            case 1:
                                ei.AñadirVenta(listaempleados);
                                break;
                            default:
                                Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna.");
                                break;
                        }
                        break;
                    case 2:
                        int recogido3 = mi.GERENCIA();
                        switch (recogido3)
                        {
                            case 0:
                                gi.VentasDia(listagerencia);
                                break;
                            case 1:
                                gi.CrearPedido();
                                break;
                            default:
                                Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}
