using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class DetalleVenta
    {
        [JsonConstructor] public DetalleVenta() { }
        
        public DetalleVenta(int idDetalleVenta, int precioBruto, int idVenta, int precioNeto, string fechaInicio, string fechaFin) 
        {
            this.idDetalleVenta = idDetalleVenta;
            this.precioBruto = precioBruto;
            this.idVenta = idVenta;
            this.precioNeto = precioNeto;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public int idDetalleVenta { get; set; }
        public int precioBruto { get; set; }
        public int idVenta { get; set; }
        public int precioNeto { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }

    }
}
