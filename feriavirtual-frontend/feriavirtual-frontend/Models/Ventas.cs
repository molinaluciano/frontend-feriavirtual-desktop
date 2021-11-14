using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Ventas
    {
        [JsonConstructor] public Ventas() { }

        public Ventas(int idSolicitud, int idEstadoVenta, int idVenta, int idTipoPago)
        {
            this.idSolicitud = idSolicitud;
            this.idEstadoVenta = idEstadoVenta;
            this.idVenta = idVenta;
            this.idTipoPago = idTipoPago;
        }

        public int idSolicitud { get; set; }
        public int idEstadoVenta { get; set; }
        public int idVenta { get; set; }
        public int idTipoPago { get; set; }

    }
}
