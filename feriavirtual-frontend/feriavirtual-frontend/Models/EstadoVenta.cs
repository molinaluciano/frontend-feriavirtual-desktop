using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class EstadoVenta
    {
        [JsonConstructor] public EstadoVenta() { }
        public EstadoVenta(int idEstadoVenta, string Estado) 
        {
            this.idEstadoVenta = idEstadoVenta;
            this.estado = estado;
        }

        public int idEstadoVenta { get; set; }
        public string estado { get; set; }
    }
}
