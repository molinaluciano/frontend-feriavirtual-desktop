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
using Newtonsoft.Json;

namespace feriavirtual_frontend
{
    public partial class controlarEstadosVenta : Form
    {
        string urlVenta = "http://localhost:8080/sales";
        string urlEstadoVenta = "http://localhost:8080/select-status-sale";
        string urlExterno = "http://localhost:8080/select-user/2";
        string urlLocal = "http://localhost:8080/select-user/3";
        string urlInterno = "http://localhost:8080/select-user/4";
        string urlSolicitud = "http://localhost:8080/requests/5";

        public controlarEstadosVenta()
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

        private void dtgvControlarEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idVenta = Int32.Parse(dtgvControlarEstados.CurrentRow.Cells["dataGrididVenta"].Value.ToString());
            estadoVenta estado = new estadoVenta(idVenta);
            estado.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            estado.FormBorderStyle = FormBorderStyle.None;
            estado.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(estado);
            estado.BringToFront();
            estado.Show();
        }

        private async void controlarEstadosVenta_Load(object sender, EventArgs e)
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


            string requestVenta = await GetHtppVentas();
            string requestEstadoVenta = await GetHtppEstadoVenta();
            string requestSolicitud = await GetHtppSolicitud();

            List<Ventas> lstVentas = JsonConvert.DeserializeObject<List<Ventas>>(requestVenta);
            List<EstadoVenta> lstEstadoVenta = JsonConvert.DeserializeObject<List<EstadoVenta>>(requestEstadoVenta);
            List<Solicitudes> lstSolicitud = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitud);

            dtgvControlarEstados.DataSource = lstVentas;

            foreach (DataGridViewRow fila in dtgvControlarEstados.Rows)
            {
                string estado = "";
                string solicitud = "";
                estado = fila.Cells["dataGridIdEstadoVenta"].Value.ToString();
                solicitud = fila.Cells["dataGridIdSolicitud"].Value.ToString();

                foreach (var idSolicitud in lstSolicitud)
                {
                    if(solicitud == idSolicitud.idSolicitud.ToString())
                    {
                        foreach(var cliente in lstUsuarios)
                        {
                            if (idSolicitud.idUsuario == cliente.idUsuario)
                            {
                                fila.Cells["dataGridNomCliente"].Value = cliente.nombre;
                            }
                        }
                    }
                }
                foreach (var estadoVenta in lstEstadoVenta)
                {
                    if (estado == estadoVenta.idEstadoVenta.ToString())
                    {
                        fila.Cells["dataGridEstadoVenta"].Value = estadoVenta.estado;
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

        public async Task<string> GetHtppVentas()
        {
            WebRequest oRequestVenta = WebRequest.Create(urlVenta);
            WebResponse oResponseVenta = oRequestVenta.GetResponse();
            StreamReader srVenta = new StreamReader(oResponseVenta.GetResponseStream());
            return await srVenta.ReadToEndAsync();
        }
        public async Task<string> GetHtppEstadoVenta()
        {
            WebRequest oRequestEstadoVenta = WebRequest.Create(urlEstadoVenta);
            WebResponse oResponseEstadoVenta = oRequestEstadoVenta.GetResponse();
            StreamReader srEstadoVenta = new StreamReader(oResponseEstadoVenta.GetResponseStream());
            return await srEstadoVenta.ReadToEndAsync();
        }
        public async Task<string> GetHtppSolicitud()
        {
            WebRequest oRequestSolicitud = WebRequest.Create(urlSolicitud);
            WebResponse oResponseSolicitud = oRequestSolicitud.GetResponse();
            StreamReader srSolicitud = new StreamReader(oResponseSolicitud.GetResponseStream());
            return await srSolicitud.ReadToEndAsync();
        }
    }
}
