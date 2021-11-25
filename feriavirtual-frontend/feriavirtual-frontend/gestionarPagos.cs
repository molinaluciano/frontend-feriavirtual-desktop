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
    public partial class gestionarPagos : Form
    {
        public gestionarPagos()
        {
            InitializeComponent();
        }

        string urlVentasFinalizadas = "http://localhost:8080/sales-by-status/6";

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

        private async void gestionarPagos_Load(object sender, EventArgs e)
        {
            string requestVentasFinalizadas = await GetHtppVentasFinalizadas();

            List<Ventas> lstVentas = JsonConvert.DeserializeObject<List<Ventas>>(requestVentasFinalizadas);

            dtgvGestionarPagos.DataSource = lstVentas;

            foreach(DataGridViewRow fila in dtgvGestionarPagos.Rows)
            {
                if(Int32.Parse(fila.Cells["dataGridIdEstadoVenta"].Value.ToString()) == 6)
                {
                    fila.Cells["dataGridEstadoVenta"].Value = "PAGADA";
                }
            }
        }

        public async Task<string> GetHtppVentasFinalizadas()
        {
            WebRequest oRequestVentasFinalizadas = WebRequest.Create(urlVentasFinalizadas);
            WebResponse oResponseVentasFinalizadas = oRequestVentasFinalizadas.GetResponse();
            StreamReader srVentasFinalizadas = new StreamReader(oResponseVentasFinalizadas.GetResponseStream());
            return await srVentasFinalizadas.ReadToEndAsync();
        }

        private void dtgvGestionarPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvGestionarPagos.Columns[e.ColumnIndex].Name == "dataGridOpcion1")
            {
                int idVenta = Int32.Parse(dtgvGestionarPagos.CurrentRow.Cells["dataGrididVenta"].Value.ToString());
                detallePagos pagos = new detallePagos(idVenta);
                pagos.TopLevel = false;

                menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                pagos.FormBorderStyle = FormBorderStyle.None;
                pagos.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(pagos);
                pagos.BringToFront();
                pagos.Show();
            }
        }
    }
}
