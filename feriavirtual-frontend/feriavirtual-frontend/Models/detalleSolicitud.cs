using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class detalleSolicitud
    {
        [JsonConstructor] public detalleSolicitud() { }
        public detalleSolicitud(int idSolicitud, int idFruta, int idCalidad, int idDetalleSolicitud, int kilos) 
        {
            this.idSolicitud = idSolicitud;
            this.idFruta = idFruta;
            this.idCalidad = idCalidad;
            this.idDetalleSolicitud = idDetalleSolicitud;
            this.kilos = kilos;
        }

        public int idSolicitud { get; set; }
        public int idFruta { get; set; }
        public int idCalidad { get; set; }
        public int idDetalleSolicitud { get; set; }
        public int kilos { get; set; }

    }
}
