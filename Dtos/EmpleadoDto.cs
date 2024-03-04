using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara3.Dtos
{
    internal class EmpleadoDto
    {

        string importe = "aaaaa";
        DateTime FechaVenta = DateTime.Now;
        long idEmple = 0;
        TimeSpan Duracion;      

        public string Importe { get => importe; set => importe = value; }
        public DateTime FechaVenta1 { get => FechaVenta; set => FechaVenta = value; }
        public long IdEmple { get => idEmple; set => idEmple = value; }
        public TimeSpan Duracion1 { get => Duracion; set => Duracion = value; }

        public EmpleadoDto(string importe, DateTime fechaVenta, long idEmple, TimeSpan duracion)
        {
            this.importe = importe;
            FechaVenta = fechaVenta;
            this.idEmple = idEmple;
            Duracion = duracion;
        }

        public EmpleadoDto()
        {
        }
    }
}
