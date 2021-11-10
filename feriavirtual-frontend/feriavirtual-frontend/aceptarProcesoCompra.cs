using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using feriavirtual_frontend.Models;
using System.IO;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace feriavirtual_frontend
{
    public partial class aceptarProcesoCompra : Form
    {
        string url = "http://localhost:8080/requests/0";
        string urlEditarEstado = "http://localhost:8080/update-status-request";
        public aceptarProcesoCompra()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarVentas gestionarVenta = new gestionarVentas();
            this.Hide();
            gestionarVenta.ShowDialog();
        }

        private async void aceptarProcesoCompra_Load(object sender, EventArgs e)
        {

            string requestSolicitud = await GetHtppSolicitud();

            List<Solicitudes> lstSolicitud = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitud);

            dtgvAceptarCompra.DataSource = lstSolicitud;
        }

        public async Task<string> GetHtppSolicitud()
        {
            WebRequest oRequestSolicitud = WebRequest.Create(url);
            WebResponse oResponseSolicitud = oRequestSolicitud.GetResponse();
            StreamReader srSolicitud = new StreamReader(oResponseSolicitud.GetResponseStream());
            return await srSolicitud.ReadToEndAsync();
        }
        public async Task<string> GetHtppEditarEstado()
        {
            WebRequest oRequestEditarEstado = WebRequest.Create(urlEditarEstado);
            WebResponse oResponseEditarEstado = oRequestEditarEstado.GetResponse();
            StreamReader srEditarEstado = new StreamReader(oResponseEditarEstado.GetResponseStream());
            return await srEditarEstado.ReadToEndAsync();
        }



        private async void dtgvAceptarCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvAceptarCompra.Columns[e.ColumnIndex].Name == "dataGridOpcion1")
            {
                var editarSolicitud = new HttpClient();

                Solicitudes solicitud = new Solicitudes(3, Int32.Parse(dtgvAceptarCompra.CurrentRow.Cells["dataGridNumeroSolicitud"].Value.ToString()));

                var data = System.Text.Json.JsonSerializer.Serialize<Solicitudes>(solicitud);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                var httpResponse = await editarSolicitud.PutAsync(urlEditarEstado, content);

                if (httpResponse.IsSuccessStatusCode )
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    MessageBox.Show("Soliciutud Aceptada");
                }
                else
                {
                    MessageBox.Show("Error Solicitud no puedo ser aceptada");
                }
            }
        }
    }
}
