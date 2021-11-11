using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using feriavirtual_frontend.Models;
using Newtonsoft.Json;

namespace feriavirtual_frontend
{
    public partial class editarTransportista : Form
    {
        private int selectedIdUsuario;
        public editarTransportista(int idUsuario)
        {
            InitializeComponent();
            this.selectedIdUsuario = idUsuario;
        }

        string urlTransportista = "http://localhost:8080/select-carrier";
        string urlUpdate = "http://localhost:8080/update-user";

        private async void editarTransportista_Load(object sender, EventArgs e)
        {
            string requestTransportista = await GetHtppTransportista();

            List<Transportistas> lstTransportistas = JsonConvert.DeserializeObject<List<Transportistas>>(requestTransportista);

            Transportistas transportista = new Transportistas();

            transportista = lstTransportistas.Find(storedUsuario => storedUsuario.idUsuario.Value == selectedIdUsuario);

            txtNombres.Text = transportista.nombre;
            txtApellidoPaterno.Text = transportista.apellidoPaterno;
            txtApellidoMaterno.Text = transportista.apellidoMaterno;
            txtContrasena.Text = transportista.contrasena;
            txtCorreo.Text = transportista.correo;
            txtRut.Text = transportista.rut.ToString();
            txtNumeroIdentificador.Text = transportista.numeroIdentificador;
            txtCodigoPostal.Text = transportista.codigoPostal.ToString();
            txtDireccion.Text = transportista.direccion;
            txtTelefono.Text = transportista.telefono.ToString();

        }

        public async Task<string> GetHtppTransportista()
        {
            WebRequest oRequestTransportista = WebRequest.Create(urlTransportista);
            WebResponse oResponseTransportista = oRequestTransportista.GetResponse();
            StreamReader srTransportista = new StreamReader(oResponseTransportista.GetResponseStream());
            return await srTransportista.ReadToEndAsync();
        }
        public async Task<string> GetHtppUpdateUsuario()
        {
            WebRequest oRequestUpdateUsuario = WebRequest.Create(urlUpdate);
            WebResponse oResponseUpdateUsuario = oRequestUpdateUsuario.GetResponse();
            StreamReader srUpdateUsuario = new StreamReader(oResponseUpdateUsuario.GetResponseStream());
            return await srUpdateUsuario.ReadToEndAsync();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarTransportista gestionar = new gestionarTransportista();
            gestionar.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionar.FormBorderStyle = FormBorderStyle.None;
            gestionar.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionar);
            gestionar.BringToFront();
            gestionar.Show();
        }

        private async void btnEditarTransportista_Click(object sender, EventArgs e)
        {
            var updateTransportista= new HttpClient();
            
            Transportistas transportista = new Transportistas()
            {
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
            };

            var data = System.Text.Json.JsonSerializer.Serialize<Transportistas>(transportista);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await updateTransportista.PutAsync(urlUpdate, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                MessageBox.Show("Transportista Editado Correctamente");

                gestionarTransportista gestionarT = new gestionarTransportista();
                gestionarT.TopLevel = false;

                menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                gestionarT.FormBorderStyle = FormBorderStyle.None;
                gestionarT.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(gestionarT);
                gestionarT.BringToFront();
                gestionarT.Show();
            }
            else
            {
                MessageBox.Show("Error Transportista no puedo ser editado");
            }
        }
    }


}
