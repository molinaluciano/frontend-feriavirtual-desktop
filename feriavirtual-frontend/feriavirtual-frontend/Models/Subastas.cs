using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Subastas
    {
        [JsonConstructor] public Subastas() { }

        public Subastas(int idSolicitud, int idEstadoSubasta, int idSubasta, string fechaPublicacion, string fechaTermino, string camionSeleccionado)
        {
            this.idSolicitud = idSolicitud;
            this.idSubasta = idSubasta;
            this.fechaPublicacion = fechaPublicacion;
            this.fechaTermino = fechaTermino;
            this.camionSeleccionado = camionSeleccionado;
        }

        public int idSolicitud { get; set; }
        public int idEstadoSubasta { get; set; }
        public int idSubasta { get; set; }
        public string fechaPublicacion { get; set; }
        public string fechaTermino { get; set; }
        public string camionSeleccionado { get; set; }

    }
}
