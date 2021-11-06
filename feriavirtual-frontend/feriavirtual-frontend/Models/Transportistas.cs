using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Transportistas
    {
        public Transportistas(string correo, string contrasena, int idTransportista, string nombre, string apellidoPaterno,
                       string apellidoMaterno, int rut, string numeroIdentificador, string direccion, int codigoPostal, int telefono)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.idTransportista = idTransportista;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.rut = rut;
            this.numeroIdentificador = numeroIdentificador;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.telefono = telefono;
        }

        public string correo { get; set; }

        public string contrasena { get; set; }

        public int idTransportista { get; set; }

        public string nombre { get; set; }

        public string apellidoPaterno { get; set; }

        public string apellidoMaterno { get; set; }

        public int rut { get; set; }

        public string numeroIdentificador { get; set; }

        public string direccion { get; set; }

        public int codigoPostal { get; set; }

        public int telefono { get; set; }


    }
}
