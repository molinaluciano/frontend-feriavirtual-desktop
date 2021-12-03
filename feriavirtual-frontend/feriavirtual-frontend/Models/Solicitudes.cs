using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Solicitudes
    {
        [JsonConstructor] public Solicitudes() { }


        public Solicitudes(int idEstadoSolicitud, int idSolicitud)
        {
            this.idEstadoSolicitud = idEstadoSolicitud;
            this.idSolicitud = idSolicitud;
        }

        public Solicitudes(int idUsuario, int idTipoSolicitud, int idEstadoSolicitud, int idSolicitud, string productorSeleccionado, string fechaPublicacion)
        {
            this.idUsuario = idUsuario;
            this.idTipoSolicitud = idTipoSolicitud;
            this.idEstadoSolicitud = idEstadoSolicitud;
            this.idSolicitud = idSolicitud;
            this.productorSeleccionado = productorSeleccionado;
            this.fechaPublicacion = fechaPublicacion;
        }

        public int? idUsuario { get; set; }
        public int? idTipoSolicitud { get; set; }
        public int idEstadoSolicitud { get; set; }
        public int? idSolicitud { get; set; }
        public string productorSeleccionado { get; set; }
        public string fechaPublicacion { get; set; }
        public detallesSolicitud[] detallesSolicitud { get; set; }
        public Ventas venta { get; set; }
    }
}
