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
    public partial class detallePagos : Form
    {
        int selectedVenta = 0;
        public detallePagos(int idVenta)
        {
            InitializeComponent();
            this.selectedVenta = idVenta;
        }

        string urlVenta = "http://localhost:8080/sales";
        string urlSolicitud = "http://localhost:8080/requests/5";
        string urlDetalleSubasta = "http://localhost:8080/detail-auctions";
        string urlProductorSolicitud = "http://localhost:8080/select-producer-request";
        string urlSubasta = "http://localhost:8080/auctions";

        private async void detallePagos_Load(object sender, EventArgs e)
        {
            string requestVenta = await GetHtppVentas();
            string requestSolicitud = await GetHtppSolicitud();
            string requestDetalleSubasta = await GetHtppDetalleSubasta();
            string requestProductorSolicitud = await GetHtppProductorSolicitud();
            string requestSubasta = await GetHtppSubasta();

            List<Ventas> lstVentas = JsonConvert.DeserializeObject<List<Ventas>>(requestVenta);
            List<Solicitudes> lstSolicitud = JsonConvert.DeserializeObject<List<Solicitudes>>(requestSolicitud);
            List<Subastas> lstSubastas = JsonConvert.DeserializeObject<List<Subastas>>(requestSubasta);
            List<DetalleSubasta> lstDetalleSubasta = JsonConvert.DeserializeObject<List<DetalleSubasta>>(requestDetalleSubasta);
            List<ProductorSolicitud> lstProductorSolicitud = JsonConvert.DeserializeObject<List<ProductorSolicitud>>(requestProductorSolicitud);

            int ganancias = 0;
            int pagoTransportista = 0;
            int pagoProductor = 0;

            foreach(var venta in lstVentas)
            {
                if (venta.idVenta == selectedVenta)
                { 
                    foreach(var solicitud in lstSolicitud)
                    {
                        if (venta.idSolicitud == solicitud.idSolicitud)
                        {
                            foreach(var productorSolicitud in lstProductorSolicitud)
                            {
                                if (productorSolicitud.idSolicitud == solicitud.idSolicitud)
                                {
                                    lbPagoProductor.Text = productorSolicitud.precio.ToString();
                                    pagoProductor = productorSolicitud.precio;
                                }
                            }
                        }
                    }
                    pagoTransportista = (venta.detalleVenta.precioBruto*5)/6 - pagoProductor ;
                    int impuestos = venta.detalleVenta.precioNeto - venta.detalleVenta.precioBruto;
                    ganancias = venta.detalleVenta.precioBruto - (pagoProductor + pagoTransportista);

                    lbPagoTransportista.Text = pagoTransportista.ToString();
                    lbMontoTotal.Text = venta.detalleVenta.precioNeto.ToString();
                    lbPagoImpuestos.Text = impuestos.ToString();
                    lbGananciasEmpresa.Text = ganancias.ToString();

                } 
            }
        }

        public async Task<string> GetHtppSolicitud()
        {
            WebRequest oRequestSolicitud = WebRequest.Create(urlSolicitud);
            WebResponse oResponseSolicitud = oRequestSolicitud.GetResponse();
            StreamReader srSolicitud = new StreamReader(oResponseSolicitud.GetResponseStream());
            return await srSolicitud.ReadToEndAsync();
        }
        public async Task<string> GetHtppSubasta()
        {
            WebRequest oRequestSubasta = WebRequest.Create(urlSubasta);
            WebResponse oResponseSubasta = oRequestSubasta.GetResponse();
            StreamReader srSubasta = new StreamReader(oResponseSubasta.GetResponseStream());
            return await srSubasta.ReadToEndAsync();
        }
        public async Task<string> GetHtppDetalleSubasta()
        {
            WebRequest oRequestDetalleSubasta = WebRequest.Create(urlDetalleSubasta);
            WebResponse oResponseDetalleSubasta = oRequestDetalleSubasta.GetResponse();
            StreamReader srDetalleSubasta = new StreamReader(oResponseDetalleSubasta.GetResponseStream());
            return await srDetalleSubasta.ReadToEndAsync();
        }
        public async Task<string> GetHtppProductorSolicitud()
        {
            WebRequest oRequestProductorSolicitud = WebRequest.Create(urlProductorSolicitud);
            WebResponse oResponseProductorSolicitud = oRequestProductorSolicitud.GetResponse();
            StreamReader srProductorSolicitud = new StreamReader(oResponseProductorSolicitud.GetResponseStream());
            return await srProductorSolicitud.ReadToEndAsync();
        }
        public async Task<string> GetHtppVentas()
        {
            WebRequest oRequestVenta = WebRequest.Create(urlVenta);
            WebResponse oResponseVenta = oRequestVenta.GetResponse();
            StreamReader srVenta = new StreamReader(oResponseVenta.GetResponseStream());
            return await srVenta.ReadToEndAsync();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarPagos gestionarPagos = new gestionarPagos();
            gestionarPagos.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionarPagos.FormBorderStyle = FormBorderStyle.None;
            gestionarPagos.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionarPagos);
            gestionarPagos.BringToFront();
            gestionarPagos.Show();
        }
    }
}
