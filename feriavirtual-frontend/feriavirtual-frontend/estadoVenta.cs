using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using feriavirtual_frontend.Models;
using System.Net.Http;

namespace feriavirtual_frontend
{
    public partial class estadoVenta : Form
    {
        int selectedVenta = 0;
        public estadoVenta(int idVenta)
        {
            InitializeComponent();
            this.selectedVenta = idVenta;
        }

        string urlVenta = "http://localhost:8080/sales"; 
        string urlEstadoVenta = "http://localhost:8080/select-status-sale"; 
        string urlUpdateState = "http://localhost:8080/update-state-sale";

        private void btnVolver_Click(object sender, EventArgs e)
        {
            controlarEstadosVenta controlarEstados = new controlarEstadosVenta();
            controlarEstados.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            controlarEstados.FormBorderStyle = FormBorderStyle.None;
            controlarEstados.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(controlarEstados);
            controlarEstados.BringToFront();
            controlarEstados.Show();
        }

        private async void estadoVenta_Load(object sender, EventArgs e)
        {
            string requestEstadoVenta = await GetHtppEstadoVenta();
            string requestVenta = await GetHtppVentas();


            List<EstadoVenta> lstEstadoVenta = JsonConvert.DeserializeObject<List<EstadoVenta>>(requestEstadoVenta);
            List<Ventas> lstVentas = JsonConvert.DeserializeObject<List<Ventas>>(requestVenta);

            Ventas Venta = new Ventas();

            foreach (var venta in lstVentas)
            {
                if (venta.idVenta == selectedVenta)
                {
                    Venta = venta;
                }
            }

            DetalleVenta detalle;

            detalle = Venta.detalleVenta;

            try 
            {
                lbIdVenta.Text = selectedVenta.ToString();
                lbPrecioBruto.Text = detalle.precioBruto.ToString();
                lbprecioNeto.Text = detalle.precioNeto.ToString();
            }
            catch(NullReferenceException err) 
            {
                Console.WriteLine(err); 
            }

            


            foreach (var estadoVenta in lstEstadoVenta)
            {
                cbxEstadoVenta.Items.Add(estadoVenta.estado);
            }
        }


        private async void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            var editarVenta = new HttpClient();
            string requestVenta = await GetHtppVentas();

            List<Ventas> lstVentas = JsonConvert.DeserializeObject<List<Ventas>>(requestVenta);

            Ventas Venta = new Ventas();

            foreach(var venta in lstVentas)
            {
                if(venta.idVenta == selectedVenta)
                {
                    Venta = venta;
                }
            }

            Venta.idEstadoVenta = cbxEstadoVenta.SelectedIndex + 1;

            var data = System.Text.Json.JsonSerializer.Serialize<Ventas>(Venta);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await editarVenta.PutAsync(urlUpdateState, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                MessageBox.Show("Estado de Venta Actualizado Correctamente");
                controlarEstadosVenta controlarEstados = new controlarEstadosVenta();
                controlarEstados.TopLevel = false;


                menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                controlarEstados.FormBorderStyle = FormBorderStyle.None;
                controlarEstados.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(controlarEstados);
                controlarEstados.BringToFront();
                controlarEstados.Show();
            }
            else
            {
                MessageBox.Show("Error Estado Venta no pudo ser actualizada");
            }

        }

        public async Task<string> GetHtppUpdateState()
        {
            WebRequest oRequestUpdateState = WebRequest.Create(urlUpdateState);
            WebResponse oResponseUpdateState = oRequestUpdateState.GetResponse();
            StreamReader srEditarUpdateState = new StreamReader(oResponseUpdateState.GetResponseStream());
            return await srEditarUpdateState.ReadToEndAsync();
        }
        public async Task<string> GetHtppEstadoVenta()
        {
            WebRequest oRequestEstadoVenta = WebRequest.Create(urlEstadoVenta);
            WebResponse oResponseEstadoVenta = oRequestEstadoVenta.GetResponse();
            StreamReader srEstadoVenta = new StreamReader(oResponseEstadoVenta.GetResponseStream());
            return await srEstadoVenta.ReadToEndAsync();
        }
        public async Task<string> GetHtppVentas()
        {
            WebRequest oRequestVenta = WebRequest.Create(urlVenta);
            WebResponse oResponseVenta = oRequestVenta.GetResponse();
            StreamReader srVenta = new StreamReader(oResponseVenta.GetResponseStream());
            return await srVenta.ReadToEndAsync();
        }
    }
}
