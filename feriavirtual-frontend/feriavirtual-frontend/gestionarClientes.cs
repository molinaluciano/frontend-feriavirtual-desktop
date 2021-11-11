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
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace feriavirtual_frontend
{
    public partial class gestionarClientes : Form
    {
        string urlExterno = "http://localhost:8080/select-user/2";
        string urlLocal = "http://localhost:8080/select-user/3";
        string urlInterno = "http://localhost:8080/select-user/4";

        public gestionarClientes()
        {
            InitializeComponent();
        }
      

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarUsuarios gestionarUsuario = new gestionarUsuarios();
            gestionarUsuario.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionarUsuario.FormBorderStyle = FormBorderStyle.None;
            gestionarUsuario.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionarUsuario);
            gestionarUsuario.BringToFront();
            gestionarUsuario.Show();
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            cliente clientes = new cliente();
            clientes.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            clientes.FormBorderStyle = FormBorderStyle.None;
            clientes.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(clientes);
            clientes.BringToFront();
            clientes.Show();
        }

        private async void gestionarClientes_Load(object sender, EventArgs e)
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
            catch(WebException err)
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


            dtgvGestionarClientes.DataSource = lstUsuarios;
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dtgvGestionarClientes.CurrentCell = null;

            foreach (DataGridViewRow fila in dtgvGestionarClientes.Rows)
            {
                fila.Visible = fila.Cells["dataGridNomCliente"].Value.ToString().ToUpper().Contains(txtNombre.Text.ToUpper());
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            dtgvGestionarClientes.CurrentCell = null;

            foreach (DataGridViewRow fila in dtgvGestionarClientes.Rows)
            {
                fila.Visible = fila.Cells["dataGridRut"].Value.ToString().ToUpper().Contains(txtRut.Text.ToUpper());
            }
        }

        private void cbxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvGestionarClientes.CurrentCell = null;

            String selectedItem = cbxTipoCliente.SelectedItem.ToString();
          

            if (selectedItem == "Cliente Externo")
            {
                foreach (DataGridViewRow fila in dtgvGestionarClientes.Rows)
                {
                    fila.Visible = fila.Cells["dataGridIdTipoCliente"].Value.ToString().Contains("2");
                }
            }
            if (selectedItem == "Cliente Local")
            {
                foreach (DataGridViewRow fila in dtgvGestionarClientes.Rows)
                {
                    fila.Visible = fila.Cells["dataGridIdTipoCliente"].Value.ToString().Contains("3");
                }
            }
            if (selectedItem == "Cliente Interno")
            {
                foreach (DataGridViewRow fila in dtgvGestionarClientes.Rows)
                {
                    fila.Visible = fila.Cells["dataGridIdTipoCliente"].Value.ToString().Contains("4");
                }
            }
        }

        private async void dtgvGestionarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvGestionarClientes.Columns[e.ColumnIndex].Name == "dataGridOpcion1")
            {
                int idUsuario = Int32.Parse(dtgvGestionarClientes.CurrentRow.Cells["dataGridIdUsuario"].Value.ToString());
                editarCliente editarClientes = new editarCliente(idUsuario);
                editarClientes.TopLevel = false;

                menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                editarClientes.FormBorderStyle = FormBorderStyle.None;
                editarClientes.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(editarClientes);
                editarClientes.BringToFront();
                editarClientes.Show();

            }
            if (dtgvGestionarClientes.Columns[e.ColumnIndex].Name == "dataGridOpcion2")
            {
                var eliminarCliente = new HttpClient();

                Usuarios delteUsuario = new Usuarios(Int32.Parse(dtgvGestionarClientes.CurrentRow.Cells["dataGridIdUsuario"].Value.ToString()), Int32.Parse(dtgvGestionarClientes.CurrentRow.Cells["dataGridIdTipoCliente"].Value.ToString()));

                var data = System.Text.Json.JsonSerializer.Serialize<Usuarios>(delteUsuario);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                //var httpResponse = await eliminarCliente.DeleteAsync(urlDelete + content);

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri("http://localhost:8080/delete-user"),
                    Content = content
                };

                var httpResponse = await eliminarCliente.SendAsync(request);

                if (httpResponse.IsSuccessStatusCode && (MessageBox.Show("Seguro Desea eliminar este Cliente?","Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    MessageBox.Show("Cliente Eliminado correctamente");
                    gestionarClientes gestionarCliente = new gestionarClientes();
                    gestionarCliente.TopLevel = false;

                    menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
                    Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
                    gestionarCliente.FormBorderStyle = FormBorderStyle.None;
                    gestionarCliente.Dock = DockStyle.Fill;
                    panelDesktop.Controls.Add(gestionarCliente);
                    gestionarCliente.BringToFront();
                    gestionarCliente.Show();
                }
                else
                {
                    MessageBox.Show("Error Cliente no puedo ser eliminado");
                }
            }
            
        }
    }
}
