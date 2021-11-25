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

        private void detallePagos_Load(object sender, EventArgs e)
        {

        }

        public async Task<string> GetHtppSolicitud()
        {
            WebRequest oRequestSolicitud = WebRequest.Create(urlSolicitud);
            WebResponse oResponseSolicitud = oRequestSolicitud.GetResponse();
            StreamReader srSolicitud = new StreamReader(oResponseSolicitud.GetResponseStream());
            return await srSolicitud.ReadToEndAsync();
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
