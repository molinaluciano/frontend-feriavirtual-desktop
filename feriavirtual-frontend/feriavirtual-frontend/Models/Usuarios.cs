using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace feriavirtual_frontend.Models
{
    class Usuarios
    {
        [JsonConstructor] public Usuarios() { }
        public Usuarios(int idUsuario, int idTipoUsuario, int idPais, string nombre, string apellidoPaterno, string apellidoMaterno, string correo, 
                        string contrasena, int rut, string numeroIdentificador, string direccion, int codigoPostal, int telefono)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.idTipoUsuario = idTipoUsuario;
            this.idPais = idPais;
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.rut = rut;
            this.numeroIdentificador = numeroIdentificador;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.telefono = telefono;
        }
        public Usuarios(string nombre, string apellidoPaterno, string apellidoMaterno, string correo,
                       string contrasena, int rut, string numeroIdentificador, string direccion, int codigoPostal, int telefono)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.rut = rut;
            this.numeroIdentificador = numeroIdentificador;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.telefono = telefono;
        }
        public Usuarios(int idUsuario, int idTipoUsuario)
        {
            this.idTipoUsuario = idTipoUsuario;
            this.idUsuario = idUsuario;
        }

        public Usuarios(string correo, string contrasena, int idTipoUsuario)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.idTipoUsuario = idTipoUsuario;
        }
        public string correo { get; set; }

        public string contrasena { get; set; }

        public int? idTipoUsuario { get; set; }

        public int? idPais { get; set; }

        public int? idUsuario { get; set; }

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
