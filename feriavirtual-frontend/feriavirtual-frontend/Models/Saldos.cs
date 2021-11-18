using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Saldos
    {
        [JsonConstructor] public Saldos() { }

        public Saldos(int idSaldo, int kilos, int disponible, int idClienteComprador, int idFruta, int idCalidad) 
        {
            this.idSaldo = idSaldo;
            this.kilos = kilos;
            this.disponible = disponible;
            this.idClienteComprador = idClienteComprador;
            this.idFruta = idFruta;
            this.idCalidad = idCalidad;
        }

        public int? idSaldo { get; set; }
        public int kilos { get; set; }
        public int disponible { get; set; }
        public int? idClienteComprador { get; set; }
        public int idFruta { get; set; }
        public int idCalidad { get; set; }
    }
}
