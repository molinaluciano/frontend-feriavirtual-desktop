using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class EstadoSolicitud
    {
        [JsonConstructor] public EstadoSolicitud() { }

        public EstadoSolicitud(int idEstadoSolicitud, string descripcion) 
        {
            this.idEstadoSolicitud = idEstadoSolicitud;
            this.descripcion = descripcion;
        }

        public int idEstadoSolicitud { get; set; }
        public string descripcion { get; set; }
    }
}
