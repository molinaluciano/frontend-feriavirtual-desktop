using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Frutas
    {
        [JsonConstructor] public Frutas() { }

        public Frutas(int idFruta,int idCategoriaFruta, string nombreFruta) 
        {
            this.idFruta = idFruta;
            this.idCategoriaFruta = idCategoriaFruta;
            this.nombreFruta = nombreFruta;
        }

        public int idFruta { get; set; }
        public int idCategoriaFruta { get; set; }
        public string nombreFruta { get; set; }
    }
}
