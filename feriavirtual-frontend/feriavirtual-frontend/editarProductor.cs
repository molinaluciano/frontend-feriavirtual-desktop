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
    public partial class editarProductor : Form
    {
        private int selectedIdUsuario;
        string urlProductor = "http://localhost:8080/select-producer";
        string urlUpdate = "http://localhost:8080/update-user";
        public editarProductor(int idUsuario)
        {
            InitializeComponent();
            this.selectedIdUsuario = idUsuario;
        }
        private async void editarProductor_Load(object sender, EventArgs e)
        {
            string requestProductor = await GetHtppProductor();

            List<Productores> lstProductor = JsonConvert.DeserializeObject<List<Productores>>(requestProductor);

            Productores productor = new Productores();

            productor = lstProductor.Find(storedProductor => storedProductor.idUsuario.Value == selectedIdUsuario);

            txtNombres.Text = productor.nombre;
            txtApellidoPaterno.Text = productor.apellidoPaterno;
            txtApellidoMaterno.Text = productor.apellidoMaterno;
            txtContrasena.Text = productor.contrasena;
            txtCorreo.Text = productor.correo;
            txtRut.Text = productor.rut.ToString();
            txtNumeroIdentificador.Text = productor.numeroIdentificador;
            txtCodigoPostal.Text = productor.codigoPostal.ToString();
            txtDireccion.Text = productor.direccion;
            txtTelefono.Text = productor.telefono.ToString();
        }


        public async Task<string> GetHtppProductor()
        {
            WebRequest oRequestProductor = WebRequest.Create(urlProductor);
            WebResponse oResponseProductor = oRequestProductor.GetResponse();
            StreamReader srProductor = new StreamReader(oResponseProductor.GetResponseStream());
            return await srProductor.ReadToEndAsync();
        }
        public async Task<string> GetHtppUpdateProductor()
        {
            WebRequest oRequestUpdateProductor = WebRequest.Create(urlUpdate);
            WebResponse oResponseUpdateProductor = oRequestUpdateProductor.GetResponse();
            StreamReader srUpdateProductor = new StreamReader(oResponseUpdateProductor.GetResponseStream());
            return await srUpdateProductor.ReadToEndAsync();
        }
        private async void btnEditarProductor_Click(object sender, EventArgs e)
        {
            var updateProductor = new HttpClient();

             Productores productor = new Productores()
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

            var data = System.Text.Json.JsonSerializer.Serialize<Productores>(productor);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await updateProductor.PutAsync(urlUpdate, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                MessageBox.Show("Productor Editado Correctamente");

                gestionarProductores gestionarP = new gestionarProductores();
                gestionarP.TopLevel = false;

                menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                gestionarP.FormBorderStyle = FormBorderStyle.None;
                gestionarP.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(gestionarP);
                gestionarP.BringToFront();
                gestionarP.Show();
            }
            else
            {
                MessageBox.Show("Error Productor no puedo ser editado");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarProductores gestionar = new gestionarProductores();
            gestionar.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionar.FormBorderStyle = FormBorderStyle.None;
            gestionar.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionar);
            gestionar.BringToFront();
            gestionar.Show();
        }
    }
}
