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
    public partial class gestionarSubastas : Form
    {
        string urlSubasta = "http://localhost:8080/auctions";
        string urlSolicitudSubasta = "http://localhost:8080/requests/4";
        string urlSolicitudVenta = "http://localhost:8080/requests/5";
        string urlSolicitudTerminada = "http://localhost:8080/requests/6";
        string urlExterno = "http://localhost:8080/select-user/2";
        string urlLocal = "http://localhost:8080/select-user/3";
        string urlInterno = "http://localhost:8080/select-user/4";

        public gestionarSubastas()
        {
            InitializeComponent();
        }

        private async void gestionarSubastas_Load(object sender, EventArgs e)
        {
            string requestSubasta = await GetHtppSubasta();
            string requestSolicitudSubasta = await GetHtppSolicitudSubasta();
            string requestSolicitudVenta = await GetHtppSolicitudVenta();
            string requestSolicitudTerminada = await GetHtppSolicitudTerminada();
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

            List<Subastas> lstSubastas = JsonConvert.DeserializeObject<List<Subastas>>(requestSubasta);
            List<Solicitudes> lstSolicitudSubasta = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitudSubasta);
            List<Solicitudes> lstSolicitudVenta = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitudVenta);
            List<Solicitudes> lstSolicitudTerminada = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitudTerminada);

            List<Usuarios> lstExternos = JsonConvert.DeserializeObject<List<Usuarios>>(requestExterno);
            List<Usuarios> lstLocales = JsonConvert.DeserializeObject<List<Usuarios>>(requestLocal);
            List<Usuarios> lstInternos = JsonConvert.DeserializeObject<List<Usuarios>>(requestInterno);

            var lstUsuarios = new List<Usuarios>();

            if (lstExternos == null) { } else { lstUsuarios.AddRange(lstExternos); };
            if (lstLocales == null) { } else { lstUsuarios.AddRange(lstLocales); };
            if (lstInternos == null) { } else { lstUsuarios.AddRange(lstInternos); };

            var lstSolicitudes = new List<Solicitudes>();

            lstSolicitudes.AddRange(lstSolicitudSubasta);
            lstSolicitudes.AddRange(lstSolicitudVenta);
            lstSolicitudes.AddRange(lstSolicitudTerminada);

            foreach(var subasta in lstSubastas)
            {
                subasta.fechaPublicacion = Convert.ToDateTime(subasta.fechaPublicacion).ToString("dd/MM/yyyy");
                if(subasta.fechaTermino == null)
                {

                }
                else
                {
                    subasta.fechaTermino = Convert.ToDateTime(subasta.fechaTermino).ToString("dd/MM/yyyy");
                }
            }

            dtgvGestionarSubastas.DataSource = lstSubastas;

            string idSolicitud = "";

            foreach (DataGridViewRow fila in dtgvGestionarSubastas.Rows)
            {
                idSolicitud = fila.Cells["dataGridIdSolicitud"].Value.ToString();
                if (fila.Cells["dataGridIdEstadoSubasta"].Value.ToString() == "1")
                {
                    fila.Cells["dataGridEstadoSubasta"].Value = "ABIERTA";
                }
                if (fila.Cells["dataGridIdEstadoSubasta"].Value.ToString() == "2")
                {
                    fila.Cells["dataGridEstadoSubasta"].Value = "CERRADA";
                }

                foreach (var solicitud in lstSolicitudes)
                {
                    if(idSolicitud == solicitud.idSolicitud.ToString())
                    {
                        foreach(var cliente in lstUsuarios)
                        {
                            if(cliente.idUsuario == solicitud.idUsuario)
                            {
                                fila.Cells["dataGridNomCliente"].Value = cliente.nombre;
                            }
                        }
                    }
                }
            }
        }
        public async Task<string> GetHtppSubasta()
        {
            WebRequest oRequestSubasta = WebRequest.Create(urlSubasta);
            WebResponse oResponseSubasta = oRequestSubasta.GetResponse();
            StreamReader srSubasta = new StreamReader(oResponseSubasta.GetResponseStream());

            return await srSubasta.ReadToEndAsync();
        }
        public async Task<string> GetHtppSolicitudSubasta()
        {
            WebRequest oRequestSolicitudSubasta = WebRequest.Create(urlSolicitudSubasta);
            WebResponse oResponseSolicitudSubasta = oRequestSolicitudSubasta.GetResponse();
            StreamReader srSolicitudSubasta = new StreamReader(oResponseSolicitudSubasta.GetResponseStream());

            return await srSolicitudSubasta.ReadToEndAsync();
        }
        public async Task<string> GetHtppSolicitudVenta()
        {
            WebRequest oRequestSolicitudVenta = WebRequest.Create(urlSolicitudVenta);
            WebResponse oResponseSolicitudVenta = oRequestSolicitudVenta.GetResponse();
            StreamReader srSolicitudVenta = new StreamReader(oResponseSolicitudVenta.GetResponseStream());

            return await srSolicitudVenta.ReadToEndAsync();
        }
        public async Task<string> GetHtppSolicitudTerminada()
        {
            WebRequest oRequestSolicitudTerminada = WebRequest.Create(urlSolicitudTerminada);
            WebResponse oResponseSolicitudTerminada = oRequestSolicitudTerminada.GetResponse();
            StreamReader srSolicitudTerminada = new StreamReader(oResponseSolicitudTerminada.GetResponseStream());

            return await srSolicitudTerminada.ReadToEndAsync();
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
    }
}
