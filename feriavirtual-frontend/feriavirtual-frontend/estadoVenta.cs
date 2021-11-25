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
        string urlSolitudCerrada = "http://localhost:8080/requests/5";
        string urlExterno = "http://localhost:8080/select-user/2";
        string urlLocal = "http://localhost:8080/select-user/3";
        string urlInterno = "http://localhost:8080/select-user/4";

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

            string requestEstadoVenta = await GetHtppEstadoVenta();
            string requestVenta = await GetHtppVentas();
            string requestSolicitud = await GetHtppSolicitudes();


            List<Usuarios> lstExternos = JsonConvert.DeserializeObject<List<Usuarios>>(requestExterno);
            List<Usuarios> lstLocales = JsonConvert.DeserializeObject<List<Usuarios>>(requestLocal);
            List<Usuarios> lstInternos = JsonConvert.DeserializeObject<List<Usuarios>>(requestInterno);

            List<EstadoVenta> lstEstadoVenta = JsonConvert.DeserializeObject<List<EstadoVenta>>(requestEstadoVenta);
            List<Ventas> lstVentas = JsonConvert.DeserializeObject<List<Ventas>>(requestVenta);
            List<Solicitudes> lstSolicitud = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitud);

            var lstUsuarios = new List<Usuarios>();

            if (lstExternos == null) { } else { lstUsuarios.AddRange(lstExternos); };
            if (lstLocales == null) { } else { lstUsuarios.AddRange(lstLocales); };
            if (lstInternos == null) { } else { lstUsuarios.AddRange(lstInternos); };

            Ventas Venta = new Ventas();

            foreach (var venta in lstVentas)
            {
                if (venta.idVenta == selectedVenta)
                {
                    Venta = venta;
                }
                foreach(var solicitud in lstSolicitud)
                {
                    if (venta.idSolicitud == solicitud.idSolicitud)
                    {
                        foreach(var usuario in lstUsuarios)
                        {
                            if(solicitud.idUsuario == usuario.idUsuario)
                            {
                                lbNomCliente.Text = usuario.nombre + " " + usuario.apellidoPaterno;
                            }
                        }
                    }
                }
            }

            DetalleVenta detalle;

            detalle = Venta.detalleVenta;

            try 
            {
                lbIdVenta.Text = selectedVenta.ToString();
                lbPrecioBruto.Text = detalle.precioBruto.ToString();
                lbprecioNeto.Text = detalle.precioNeto.ToString();
                lbFecha.Text = Convert.ToDateTime(detalle.fechaInicio).ToString("dd/MM/yyyy");
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
        public async Task<string> GetHtppSolicitudes()
        {
            WebRequest oRequestSolicitudes = WebRequest.Create(urlSolitudCerrada);
            WebResponse oResponseSolicitudes = oRequestSolicitudes.GetResponse();
            StreamReader srSolicitudes = new StreamReader(oResponseSolicitudes.GetResponseStream());
            return await srSolicitudes.ReadToEndAsync();
        }

        public async Task<string> GetHtppLocal()
        {
            WebRequest oRequestLocal = WebRequest.Create(urlLocal);
            WebResponse oResponseLocal = oRequestLocal.GetResponse();
            StreamReader srLocal = new StreamReader(oResponseLocal.GetResponseStream());

            return await srLocal.ReadToEndAsync();
        }
        public async Task<string> GetHtppExterno()
        {
            WebRequest oRequestExterno = WebRequest.Create(urlExterno);
            WebResponse oResponseExterno = oRequestExterno.GetResponse();
            StreamReader srExterno = new StreamReader(oResponseExterno.GetResponseStream());
            return await srExterno.ReadToEndAsync();
        }
        public async Task<string> GetHtppInterno()
        {
            WebRequest oRequestInterno = WebRequest.Create(urlInterno);
            WebResponse oResponseInterno = oRequestInterno.GetResponse();
            StreamReader srInterno = new StreamReader(oResponseInterno.GetResponseStream());

            return await srInterno.ReadToEndAsync();
        }

    }
}
