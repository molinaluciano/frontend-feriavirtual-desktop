using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class DetalleSubasta
    {
        [JsonConstructor] public DetalleSubasta() { }

        public DetalleSubasta(int idSubasta, int idDetalleSubasta, int precio, int idCamion) 
        {
            this.idSubasta = idSubasta;
            this.idDetalleSubasta = idDetalleSubasta;
            this.precio = precio;
            this.idCamion = idCamion;
        }

        public int idSubasta { get; set; }
        public int idDetalleSubasta { get; set; }
        public int precio { get; set; }
        public int idCamion { get; set; }
    }
}
