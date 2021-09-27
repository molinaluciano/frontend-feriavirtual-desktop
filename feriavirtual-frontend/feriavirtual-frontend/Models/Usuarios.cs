using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Usuarios
    {
        public Usuarios(string correo, string contrasena, int idTipoUsuario)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.idTipoUsuario = idTipoUsuario;
        }

        public string correo { get; set; }

        public string contrasena { get; set; }

        public int idTipoUsuario { get; set; }
    }
}
