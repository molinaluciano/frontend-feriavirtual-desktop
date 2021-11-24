using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Calidad
    {
        [JsonConstructor] public Calidad() { }
        public Calidad(int idCalidad, string calidad) 
        {
            this.idCalidad = idCalidad;
            this.calidad = calidad;
        }

        public int idCalidad { get; set; }

        public string calidad { get; set; }
    }
}
