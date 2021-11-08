using System.Text.Json.Serialization;

namespace feriavirtual_frontend.Models
{
    class Contrato
    {
        [JsonConstructor] public Contrato() { }

        public Contrato(int idContrato, string descripcion, string fechaEmision, string fechaExpiracion, string firmas, int idEstadoContrato)
        {
            this.idContrato = idContrato;
            this.descripcion = descripcion;
            this.fechaEmision = fechaEmision;
            this.fechaExpiracion = fechaExpiracion;
            this.firmas = firmas;
            this.idEstadoContrato = idEstadoContrato;
        }

        public int? idContrato { get; set; }
        public string descripcion { get; set; }
        public string fechaEmision { get; set; }
        public string fechaExpiracion { get; set; }
        public string firmas { get; set; }
        public int idEstadoContrato { get; set; }

    }
}
