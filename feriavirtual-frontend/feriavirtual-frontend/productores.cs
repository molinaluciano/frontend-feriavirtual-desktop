using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using feriavirtual_frontend.Models;
using System.IO;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace feriavirtual_frontend
{
    public partial class productores : Form
    {
        public productores()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarProductores gestionarProductor = new gestionarProductores();
            this.Hide();
            gestionarProductor.ShowDialog();
        }

        private async void btnIngresarProductor_Click(object sender, EventArgs e)
        {
            string urlContrato = "http://localhost:8080/create-contract";
            string urlProductor = "http://localhost:8080/create-user";
            string selectedFirma = "";

            if (chkBoxSi.Checked)
            {
                selectedFirma = "1";
            }
            else
            {
                selectedFirma = "0";
            }

            var contrato = new HttpClient();
            var productor = new HttpClient();

            Contrato contratos = new Contrato()
            {
                idContrato = null,
                descripcion = txtDescipcion.Text,
                firmas = selectedFirma,
                fechaEmision = "",
                fechaExpiracion = "",
                idEstadoContrato = 1
            };


            var dataContrato = System.Text.Json.JsonSerializer.Serialize<Contrato>(contratos);
            HttpContent contentContrato = new StringContent(dataContrato, System.Text.Encoding.UTF8, "application/json");
            var httpResponseContrato = await contrato.PostAsync(urlContrato, contentContrato);

            var id = "";
            if (httpResponseContrato.IsSuccessStatusCode)
            {
                var resultContrato = await httpResponseContrato.Content.ReadAsStringAsync();
                var resultId = JObject.Parse(resultContrato);
                id = resultId["id"].ToString();
            }
            else
            {
                MessageBox.Show("Error Contrato no ingresado");
            }

            Productores productores = new Productores()
            {
                correo = txtCorreo.Text,
                idUsuario = null,
                nombre = txtNombres.Text,
                apellidoPaterno = txtApellidoPaterno.Text,
                apellidoMaterno = txtApellidoMaterno.Text,
                contrasena = txtContrasena.Text,
                rut = Int32.Parse(txtRut.Text),
                numeroIdentificador = txtNumeroIdentificador.Text,
                direccion = txtDireccion.Text,
                codigoPostal = Int32.Parse(txtCodigoPostal.Text),
                telefono = Int32.Parse(txtTelefono.Text),
                idContrato = Int32.Parse(id),
                idTipoUsuario = 6,
                idPais = 1
            };

            var data = System.Text.Json.JsonSerializer.Serialize<Productores>(productores);

            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await productor.PostAsync(urlProductor, content);


            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                MessageBox.Show("Productor ingresado correctamente");

                gestionarProductores windowGestionarProductores = new gestionarProductores();
                this.Hide();
                windowGestionarProductores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error Usuario no fue ingresado");
            }
        }



        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            gestionarProductores gestionarProductores = new gestionarProductores();
            this.Hide();
            gestionarProductores.ShowDialog();
        }

        private void productores_Load(object sender, EventArgs e)
        {
            label19.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
            label18.Text = DateTime.UtcNow.AddYears(1).ToString("dd/MM/yyyy");
        }
    }
}
