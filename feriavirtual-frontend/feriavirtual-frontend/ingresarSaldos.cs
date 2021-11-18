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
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace feriavirtual_frontend
{
    public partial class ingresarSaldos : Form
    {

        string urlFruta = "http://localhost:8080/select-fruit";
        string urlCategoria = "http://localhost:8080/select-category-fruit"; 
        string urlCalidad = "http://localhost:8080/select-quality-fruit";
        string urlSaldo = "http://localhost:8080/create-balance";

        public ingresarSaldos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarVentas gestionarVenta = new gestionarVentas();
            gestionarVenta.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionarVenta.FormBorderStyle = FormBorderStyle.None;
            gestionarVenta.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionarVenta);
            gestionarVenta.BringToFront();
            gestionarVenta.Show();
        }

        private async void ingresarSaldos_Load(object sender, EventArgs e)
        {
            string requestFruta = await GetHtppFruta();
            string requestCategoria = await GetHtppCategoria();
            string requestCalidad = await GetHtppCalidad();

            List<Frutas> lstFrutas = JsonConvert.DeserializeObject<List<Frutas>>(requestFruta);
            List<Categoria> lstCategoria = JsonConvert.DeserializeObject<List<Categoria>>(requestCategoria);
            List<Calidad> lstCalidad = JsonConvert.DeserializeObject<List<Calidad>>(requestCalidad);

            foreach (var categoria in lstCategoria)
            {
                cbxCategoria.Items.Add(categoria.categoria);
            }
            foreach (var calidad in lstCalidad)
            {
                cbxCalidad.Items.Add(calidad.calidad);
            }
        }

        public async Task<string> GetHtppFruta()
        {
            WebRequest oRequestFruta = WebRequest.Create(urlFruta);
            WebResponse oResponseFruta = oRequestFruta.GetResponse();
            StreamReader srFruta = new StreamReader(oResponseFruta.GetResponseStream());
            return await srFruta.ReadToEndAsync();
        }
        public async Task<string> GetHtppCategoria()
        {
            WebRequest oRequestCategoria = WebRequest.Create(urlCategoria);
            WebResponse oResponseCategoria = oRequestCategoria.GetResponse();
            StreamReader srCategoria = new StreamReader(oResponseCategoria.GetResponseStream());
            return await srCategoria.ReadToEndAsync();
        }
        public async Task<string> GetHtppCalidad()
        {
            WebRequest oRequestCalidad = WebRequest.Create(urlCalidad);
            WebResponse oResponseCalidad = oRequestCalidad.GetResponse();
            StreamReader srCalidad = new StreamReader(oResponseCalidad.GetResponseStream());
            return await srCalidad.ReadToEndAsync();
        }

        private async void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requestFruta = await GetHtppFruta();
            string requestCategoria = await GetHtppCategoria();

            List<Frutas> lstFrutas = JsonConvert.DeserializeObject<List<Frutas>>(requestFruta);
            List<Categoria> lstCategoria = JsonConvert.DeserializeObject<List<Categoria>>(requestCategoria);

            switch (cbxCategoria.SelectedIndex)
            {
                case 0:
                    cbxFruta.Items.Clear();
                    foreach (var fruta in lstFrutas)
                    {
                        if (fruta.idCategoriaFruta == 1)
                        {
                            cbxFruta.Items.Add(fruta.nombreFruta);
                        }
                    }
                    break;
                case 1:
                    cbxFruta.Items.Clear();
                    foreach (var fruta in lstFrutas)
                    {
                        if (fruta.idCategoriaFruta == 2)
                        {
                            cbxFruta.Items.Add(fruta.nombreFruta);
                        }
                    }
                    break;
                case 2:
                    cbxFruta.Items.Clear();
                    foreach (var fruta in lstFrutas)
                    {
                        if (fruta.idCategoriaFruta == 3)
                        {
                            cbxFruta.Items.Add(fruta.nombreFruta);
                        }
                    }
                    break;
                case 3:
                    cbxFruta.Items.Clear();
                    foreach (var fruta in lstFrutas)
                    {
                        if (fruta.idCategoriaFruta == 4)
                        {
                            cbxFruta.Items.Add(fruta.nombreFruta);
                        }
                    }
                    break;
                case 4:
                    cbxFruta.Items.Clear();
                    foreach (var fruta in lstFrutas)
                    {
                        if (fruta.idCategoriaFruta == 5)
                        {
                            cbxFruta.Items.Add(fruta.nombreFruta);
                        }
                    }
                    break;
            }

            
        }

        private async void btnAgregarSaldo_Click(object sender, EventArgs e)
        {
            var saldos = new HttpClient();
            string requestFruta = await GetHtppFruta();

            List<Frutas> lstFrutas = JsonConvert.DeserializeObject<List<Frutas>>(requestFruta);

            int selectedCalidad = cbxCalidad.SelectedIndex + 1;
            int selectedFruta = 0;

            foreach(var fruta in lstFrutas)
            {
                if(fruta.nombreFruta == cbxFruta.SelectedItem.ToString())
                {
                    selectedFruta = fruta.idFruta;
                }
            }

            Saldos saldo = new Saldos()
            {
                idSaldo = null,
                kilos = Int32.Parse(txtKg.Text),
                disponible = 1,
                idClienteComprador = null,
                idCalidad = selectedCalidad,
                idFruta = selectedFruta
            };

            var data = System.Text.Json.JsonSerializer.Serialize<Saldos>(saldo);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await saldos.PostAsync(urlSaldo, content);

            if (httpResponse.IsSuccessStatusCode) { 
           
                var result = await httpResponse.Content.ReadAsStringAsync();

                MessageBox.Show("Saldo Ingresado Correctamente");

                gestionarVentas windowGestionarVentas = new gestionarVentas();
                windowGestionarVentas.TopLevel = false;

                menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                windowGestionarVentas.FormBorderStyle = FormBorderStyle.None;
                windowGestionarVentas.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(windowGestionarVentas);
                windowGestionarVentas.BringToFront();
                windowGestionarVentas.Show();
            }
            else
            {
                MessageBox.Show("Error Saldo no fue ingresado");
            }
        }
    }
}
