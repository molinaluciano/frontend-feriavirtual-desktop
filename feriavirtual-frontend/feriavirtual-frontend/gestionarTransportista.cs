using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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

            foreach(Transportistas transportistas in lstTransportistas)
            {
                transportistas.idPais = 1;
                transportistas.idTipoUsuario = 7;
            }

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

        private async void dtgvGestionarTransportistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvGestionarTransportistas.Columns[e.ColumnIndex].Name == "dataGridOpcion1")
            {
                int idUsuario = Int32.Parse(dtgvGestionarTransportistas.CurrentRow.Cells["dataGridIdTransportista"].Value.ToString());
                editarTransportista editar = new editarTransportista(idUsuario);
                this.Hide();
                editar.ShowDialog();
            }

            if (dtgvGestionarTransportistas.Columns[e.ColumnIndex].Name == "dataGridOpcion2")
            {
                var eliminarTransportista = new HttpClient();

                Transportistas delteTransportista = new Transportistas(Int32.Parse(dtgvGestionarTransportistas.CurrentRow.Cells["dataGridIdTransportista"].Value.ToString()), 7);

                var data = System.Text.Json.JsonSerializer.Serialize<Transportistas>(delteTransportista);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                //var httpResponse = await eliminarCliente.DeleteAsync(urlDelete + content);

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri("http://localhost:8080/delete-user"),
                    Content = content
                };

                var httpResponse = await eliminarTransportista.SendAsync(request);

                if (httpResponse.IsSuccessStatusCode && (MessageBox.Show("Seguro Desea eliminar este Transportista?", "Eliminar Transportista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    MessageBox.Show("Transportista Eliminado correctamente");
                    gestionarTransportista gestionarT = new gestionarTransportista();
                    this.Hide();
                    gestionarT.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error Transportista no puedo ser eliminado");
                }
            }
        }

    }
}
