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
    public partial class gestionarTransportista : Form
    {
        string url = "http://localhost:8080/select-carrier";
        public gestionarTransportista()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarUsuarios gestionarUsuario = new gestionarUsuarios();
            this.Hide();
            gestionarUsuario.ShowDialog();
        }

        private void btnNuevoTransportista_Click(object sender, EventArgs e)
        {
            transportista transportistas = new transportista();
            this.Hide();
            transportistas.ShowDialog();
        }

        private async void gestionarTransportista_Load(object sender, EventArgs e)
        {

            string requestTransportista = await GetHtppTransportista();

            List<Transportistas> lstTransportistas = JsonConvert.DeserializeObject<List<Transportistas>>(requestTransportista);

            dtgvGestionarTransportistas.DataSource = lstTransportistas;

        }
        public async Task<string> GetHtppTransportista()
        {
            WebRequest oRequestExterno = WebRequest.Create(url);
            WebResponse oResponseExterno = oRequestExterno.GetResponse();
            StreamReader srExterno = new StreamReader(oResponseExterno.GetResponseStream());
            return await srExterno.ReadToEndAsync();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dtgvGestionarTransportistas.CurrentCell = null;


            foreach (DataGridViewRow fila in dtgvGestionarTransportistas.Rows)
            {
                fila.Visible = fila.Cells["dataGridNomTransportista"].Value.ToString().ToUpper().Contains(txtNombre.Text.ToUpper());
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            dtgvGestionarTransportistas.CurrentCell = null;


            foreach (DataGridViewRow fila in dtgvGestionarTransportistas.Rows)
            {
                fila.Visible = fila.Cells["dataGridRut"].Value.ToString().ToUpper().Contains(txtRut.Text.ToUpper());
            }
        }
    }
}
