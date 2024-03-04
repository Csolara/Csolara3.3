using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara3.Dtos
{
    internal class GerenciaDto
    {

        string NombreProducto = "aaaaa";
        int Cantidad = 0;
        string FechaEntrega = "dd-MM-yyyy";
        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string FechaEntrega1 { get => FechaEntrega; set => FechaEntrega = value; }

        public GerenciaDto(string nombreProducto, int cantidad, string fechaEntrega)
        {
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            FechaEntrega = fechaEntrega;
        }

        public GerenciaDto()
        {
        }
    }
}
