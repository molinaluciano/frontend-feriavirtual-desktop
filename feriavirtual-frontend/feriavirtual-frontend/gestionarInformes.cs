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
    public partial class gestionarInformes : Form
    {
        public gestionarInformes()
        {
            InitializeComponent();
        }

        string urlVenta = "http://localhost:8080/sales";
        string urlSolicitud = "http://localhost:8080/requests";
        string urlDetalleSubasta = "http://localhost:8080/detail-auctions";
        string urlProductorSolicitud = "http://localhost:8080/select-producer-request";
        string urlSubasta = "http://localhost:8080/auctions";
        string urlSaldo = "http://localhost:8080/balance";


        private async void cbxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requestVenta = await GetHtppVentas();
            string requestSolicitud = await GetHtppSolicitud();
            string requestSaldo = await GetHtppSaldo();

            List<Ventas> lstVentas = JsonConvert.DeserializeObject<List<Ventas>>(requestVenta);
            List<Solicitudes> lstSolicitud = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitud);
            List<Saldos> lstSaldos = JsonConvert.DeserializeObject<List<Saldos>>(requestSaldo);

            int solicitudesRealizadas = 0;
            int ventasRealizadas = 0;
            int saldosVendidos = 0;
            double ganancias = 0;

            foreach (var solicitud in lstSolicitud)
            {
                DateTime fechaSolicitud;
                fechaSolicitud = Convert.ToDateTime(solicitud.fechaPublicacion);
                if (cbxMes.SelectedItem.ToString() == fechaSolicitud.Month.ToString())
                {
                    solicitudesRealizadas = solicitudesRealizadas + 1;
                }
                if(solicitud.venta == null)
                {

                }
                else
                {
                    DateTime fechaVenta;
                    fechaVenta = Convert.ToDateTime(solicitud.venta.detalleVenta.fechaFin);

                    if (solicitud.venta.idEstadoVenta == 6 && fechaVenta.Month.ToString() == cbxMes.SelectedItem.ToString())
                    {
                        ventasRealizadas = ventasRealizadas + 1;
                        ganancias = ganancias + (solicitud.venta.detalleVenta.precioBruto - solicitud.venta.detalleVenta.precioBruto / 1.2);
                    }
                }
                if (solicitud.idTipoSolicitud == 1 && fechaSolicitud.Month.ToString() == cbxMes.SelectedItem.ToString())
                {
                    saldosVendidos = saldosVendidos + 1;
                }
            }


            lbCantidadSolicitudes.Text = solicitudesRealizadas.ToString();
            lbVentasFinalizadas.Text = ventasRealizadas.ToString();
            lbSaldosVendidos.Text = saldosVendidos.ToString();
            lbGanancias.Text = ganancias.ToString();

            lbCantidadSolicitudes.Visible = true;
            lbGanancias.Visible = true;
            lbSaldosVendidos.Visible = true;
            lbVentasFinalizadas.Visible = true;

        }


        public async Task<string> GetHtppSolicitud()
        {
            WebRequest oRequestSolicitud = WebRequest.Create(urlSolicitud);
            WebResponse oResponseSolicitud = oRequestSolicitud.GetResponse();
            StreamReader srSolicitud = new StreamReader(oResponseSolicitud.GetResponseStream());
            return await srSolicitud.ReadToEndAsync();
        }
        public async Task<string> GetHtppSaldo()
        {
            WebRequest oRequestSaldo = WebRequest.Create(urlSaldo);
            WebResponse oResponseSaldo = oRequestSaldo.GetResponse();
            StreamReader srSaldo = new StreamReader(oResponseSaldo.GetResponseStream());
            return await srSaldo.ReadToEndAsync();
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
