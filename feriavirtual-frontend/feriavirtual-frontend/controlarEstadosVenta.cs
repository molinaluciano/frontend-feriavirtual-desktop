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
            int idVenta = Int32.Parse(dtgvControlarEstados.CurrentRow.Cells["dataGridVenta"].Value.ToString());
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
            string requestVenta = await GetHtppVentas();

            List<Ventas> lstVentas = JsonConvert.DeserializeObject<List<Ventas>>(requestVenta);

            dtgvControlarEstados.DataSource = lstVentas;
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
