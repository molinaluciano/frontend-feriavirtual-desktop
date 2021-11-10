using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using feriavirtual_frontend.Models;

namespace feriavirtual_frontend
{
    public partial class transportista : Form
    {
        public transportista()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarTransportista gestionarTransportistas = new gestionarTransportista();
            this.Hide();
            gestionarTransportistas.ShowDialog();
        }

        private async void btnAgregarTransportista_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:8080/create-user";
            var transportista = new HttpClient();

            Transportistas transportistas = new Transportistas()
            {
                idUsuario = null,
                nombre = txtNombres.Text,
                apellidoPaterno = txtApellidoPaterno.Text,
                apellidoMaterno = txtApellidoMaterno.Text,
                correo = txtCorreo.Text,
                contrasena = txtContrasena.Text,
                rut = Int32.Parse(txtRut.Text),
                numeroIdentificador = txtNumeroIdentificador.Text,
                direccion = txtDireccion.Text,
                codigoPostal = Int32.Parse(txtCodigoPostal.Text),
                telefono = Int32.Parse(txtTelefono.Text),
                idPais = 1,
                idTipoUsuario = 7
            };

            var data = JsonSerializer.Serialize<Transportistas>(transportistas);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await transportista.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                MessageBox.Show("Transportista Ingresado Correctamente");

                gestionarTransportista windowGestionarTransportista = new gestionarTransportista();
                this.Hide();
                windowGestionarTransportista.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error Transportista no fue ingresado");
            }

        }
    }
}
