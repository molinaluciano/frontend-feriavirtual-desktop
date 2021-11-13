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
    public partial class detalleProcesoCompra : Form
    {

        private int selectedSolicitud;
        public detalleProcesoCompra(int idSolicitud)
        {
            InitializeComponent();
            this.selectedSolicitud = idSolicitud;
        }

        string urlSolicitud = "http://localhost:8080/requests/0";
        string urlExterno = "http://localhost:8080/select-user/2";
        string urlLocal = "http://localhost:8080/select-user/3";
        string urlInterno = "http://localhost:8080/select-user/4";
        string urlDetalleSolicitud = "http://localhost:8080/detail-requests";

        private async void detalleProcesoCompra_Load(object sender, EventArgs e)
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
            string requestDetalleSolicitud = await GetHtppDetalleSolicitud();

            List<Solicitudes> lstSolicitud = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitud);
            List<detalleSolicitud> lstDetalleSolicitud = JsonConvert.DeserializeObject<List<detalleSolicitud>>(requestDetalleSolicitud);


            foreach (var solicitud in lstSolicitud)
            {
                if (solicitud.idSolicitud == selectedSolicitud)
                {
                    lbTipoSolicitud.Text = solicitud.idTipoSolicitud.ToString();
                    lbPedido.Text = solicitud.idSolicitud.ToString();
                }
                foreach(var usuario in lstUsuarios)
                {
                    if (usuario.idUsuario == solicitud.idUsuario)
                    {
                        lbNomCliente.Text = usuario.nombre;
                        lbPais.Text = usuario.idPais.ToString();
                    }
                }
                foreach (var detalle in lstDetalleSolicitud)
                {
                    if(detalle.idSolicitud == solicitud.idSolicitud)
                    {
                        lbFruta.Text = detalle.idFruta.ToString();
                        lbKilos.Text = detalle.kilos.ToString();
                        lbCalidad.Text = detalle.idCalidad.ToString();
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
            WebRequest oRequestSolicitud = WebRequest.Create(urlSolicitud);
            WebResponse oResponseSolicitud = oRequestSolicitud.GetResponse();
            StreamReader srSolicitud = new StreamReader(oResponseSolicitud.GetResponseStream());
            return await srSolicitud.ReadToEndAsync();
        }
        public async Task<string> GetHtppDetalleSolicitud()
        {
            WebRequest oRequestDetalleSolicitud = WebRequest.Create(urlDetalleSolicitud);
            WebResponse oResponseDetalleSolicitud = oRequestDetalleSolicitud.GetResponse();
            StreamReader srDetalleSolicitud = new StreamReader(oResponseDetalleSolicitud.GetResponseStream());
            return await srDetalleSolicitud.ReadToEndAsync();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            aceptarProcesoCompra aceptarProceso = new aceptarProcesoCompra();
            aceptarProceso.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            aceptarProceso.FormBorderStyle = FormBorderStyle.None;
            aceptarProceso.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(aceptarProceso);
            aceptarProceso.BringToFront();
            aceptarProceso.Show(); ;
        }
    }
}
