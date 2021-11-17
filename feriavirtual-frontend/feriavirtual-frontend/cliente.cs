using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using feriavirtual_frontend.Models;
using System.IO;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace feriavirtual_frontend
{
    public partial class cliente : Form
    {
        
        public cliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarClientes gestionarCliente = new gestionarClientes();
            gestionarCliente.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionarCliente.FormBorderStyle = FormBorderStyle.None;
            gestionarCliente.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionarCliente);
            gestionarCliente.BringToFront();
            gestionarCliente.Show();
        }

        private async void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:8080/create-user";
            var cliente = new HttpClient();

            int selectedTipoCliente = cbxTipoCliente.SelectedIndex + 2;
            int selectedPais = cbxPais.SelectedIndex + 1;

            Usuarios usuarios = new Usuarios()
            {
                idUsuario = null,
                idTipoUsuario = selectedTipoCliente,
                idPais = selectedPais,
                nombre = txtNombres.Text,
                apellidoPaterno = txtApellidoPaterno.Text,
                apellidoMaterno = txtApellidoMaterno.Text,
                correo = txtCorreo.Text,
                contrasena = txtContrasena.Text,
                rut = Int32.Parse(txtRut.Text),
                numeroIdentificador = txtNumeroIdentificador.Text,
                direccion = txtDireccion.Text,
                codigoPostal = Int32.Parse(txtCodigoPostal.Text),
                telefono = Int32.Parse(txtTelefono.Text)
            };

            var data = JsonSerializer.Serialize<Usuarios>(usuarios);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await cliente.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                MessageBox.Show("Usuario Ingresado Correctamente");

                gestionarClientes windowGestionarClientes = new gestionarClientes();
                windowGestionarClientes.TopLevel = false;

                menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                windowGestionarClientes.FormBorderStyle = FormBorderStyle.None;
                windowGestionarClientes.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(windowGestionarClientes);
                windowGestionarClientes.BringToFront();
                windowGestionarClientes.Show();
            }
            else
            {
                MessageBox.Show("Error Usuario no fue ingresado");
            }
        }

        private void cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
