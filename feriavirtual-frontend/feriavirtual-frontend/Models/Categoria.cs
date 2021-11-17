using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Categoria
    {
        [JsonConstructor] public Categoria() { }

        public Categoria(int idCategoria, string categoria) 
        {
            this.idCategoria = idCategoria;
            this.categoria = categoria;
        }

        public int idCategoria { get; set; }
        public string categoria { get; set; }
    }   
}
