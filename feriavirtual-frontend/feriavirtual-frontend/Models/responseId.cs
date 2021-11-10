using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class responseId
    {
        [JsonConstructor] public responseId() { }
        public responseId(int id)
        {
            this.id = id;
        }

        int id { get; set; }
    }
}
