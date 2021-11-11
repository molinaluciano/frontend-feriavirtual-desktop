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
        string urlExterno = "http://localhost:8080/select-user/2";
        string urlLocal = "http://localhost:8080/select-user/3";
        string urlInterno = "http://localhost:8080/select-user/4";
        public aceptarProcesoCompra()
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
            gestionarVenta.Show(); ;
        }

        private async void aceptarProcesoCompra_Load(object sender, EventArgs e)
        {
            string requestExterno = "";
            string requestLocal = "";
            string requestInterno = "";
            try
            {
                requestExterno = await GetHtppExterno();
                requestLocal = await GetHtppLocal();
                requestInterno = await GetHtppInterno();
            }
            catch (WebException err)
            {
                Console.WriteLine(err);
            }


            List<Usuarios> lstExternos = JsonConvert.DeserializeObject<List<Usuarios>>(requestExterno);
            List<Usuarios> lstLocales = JsonConvert.DeserializeObject<List<Usuarios>>(requestLocal);
            List<Usuarios> lstInternos = JsonConvert.DeserializeObject<List<Usuarios>>(requestInterno);

            var lstUsuarios = new List<Usuarios>();

            if (lstExternos == null) { } else { lstUsuarios.AddRange(lstExternos); };
            if (lstLocales == null) { } else { lstUsuarios.AddRange(lstLocales); };
            if (lstInternos == null) { } else { lstUsuarios.AddRange(lstInternos); };

            string requestSolicitud = await GetHtppSolicitud();

            List<Solicitudes> lstSolicitud = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitud);
            int  idCliente = 0;

            dtgvAceptarCompra.DataSource = lstSolicitud;
            foreach (DataGridViewRow fila in dtgvAceptarCompra.Rows)
            {
                idCliente = Int32.Parse(fila.Cells["dataGridIdUsuario"].Value.ToString());
                foreach (var cliente in lstUsuarios)
                {
                    if(cliente.idUsuario == idCliente)
                    {
                        fila.Cells["dataGridNombreCliente"].Value = cliente.nombre;
                    } 
                }
            }
        }
        public async Task<string> GetHtppExterno()
        {
            WebRequest oRequestExterno = WebRequest.Create(urlExterno);
            WebResponse oResponseExterno = oRequestExterno.GetResponse();
            StreamReader srExterno = new StreamReader(oResponseExterno.GetResponseStream());
            return await srExterno.ReadToEndAsync();
        }

        public async Task<string> GetHtppLocal()
        {
            WebRequest oRequestLocal = WebRequest.Create(urlLocal);
            WebResponse oResponseLocal = oRequestLocal.GetResponse();
            StreamReader srLocal = new StreamReader(oResponseLocal.GetResponseStream());

            return await srLocal.ReadToEndAsync();
        }
        public async Task<string> GetHtppInterno()
        {
            WebRequest oRequestInterno = WebRequest.Create(urlInterno);
            WebResponse oResponseInterno = oRequestInterno.GetResponse();
            StreamReader srInterno = new StreamReader(oResponseInterno.GetResponseStream());

            return await srInterno.ReadToEndAsync();
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
                    aceptarProcesoCompra aceptar = new aceptarProcesoCompra();
                    aceptar.TopLevel = false;

                    menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                    Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                    aceptar.FormBorderStyle = FormBorderStyle.None;
                    aceptar.Dock = DockStyle.Fill;
                    panelDesktop.Controls.Add(aceptar);
                    aceptar.BringToFront();
                    aceptar.Show();
                }
                else
                {
                    MessageBox.Show("Error Solicitud no puedo ser aceptada");
                }

            }
            if (dtgvAceptarCompra.Columns[e.ColumnIndex].Name == "dataGridOpcion2")
            {
                var editarSolicitud = new HttpClient();

                Solicitudes solicitud = new Solicitudes(1, Int32.Parse(dtgvAceptarCompra.CurrentRow.Cells["dataGridNumeroSolicitud"].Value.ToString()));

                var data = System.Text.Json.JsonSerializer.Serialize<Solicitudes>(solicitud);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                var httpResponse = await editarSolicitud.PutAsync(urlEditarEstado, content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    MessageBox.Show("Soliciutud Rechazada");
                    aceptarProcesoCompra aceptar = new aceptarProcesoCompra();
                    aceptar.TopLevel = false;

                    menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                    Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                    aceptar.FormBorderStyle = FormBorderStyle.None;
                    aceptar.Dock = DockStyle.Fill;
                    panelDesktop.Controls.Add(aceptar);
                    aceptar.BringToFront();
                    aceptar.Show();
                }
                else
                {
                    MessageBox.Show("Error Solicitud no puedo ser rechazada");
                }
            }
            if (dtgvAceptarCompra.Columns[e.ColumnIndex].Name == "dataGridOpcion3")
            {
                int idSolicitud = Int32.Parse(dtgvAceptarCompra.CurrentRow.Cells["dataGridNumeroSolicitud"].Value.ToString());
                detalleProcesoCompra detalle = new detalleProcesoCompra(idSolicitud);
                detalle.TopLevel = false;

                menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                detalle.FormBorderStyle = FormBorderStyle.None;
                detalle.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(detalle);
                detalle.BringToFront();
                detalle.Show();
            }
        }
    }
}
