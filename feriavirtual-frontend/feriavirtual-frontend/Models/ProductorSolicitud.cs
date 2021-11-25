using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class ProductorSolicitud
    {
        [JsonConstructor] public ProductorSolicitud() { }

        public ProductorSolicitud(int idPrductorSolicitud, int precio, int idProductor, int idSolicitud) 
        {
            this.idPrductorSolicitud = idPrductorSolicitud;
            this.precio = precio;
            this.idProductor = idProductor;
            this.idSolicitud = idSolicitud;
        }

        public int idPrductorSolicitud { get; set; }
        public int precio { get; set; }
        public int idProductor { get; set; }
        public int idSolicitud { get; set; }
    }
}
