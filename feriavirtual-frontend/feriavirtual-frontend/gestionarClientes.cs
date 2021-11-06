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
        string urlLocal   = "http://localhost:8080/select-user/3";
        string urlInterno = "http://localhost:8080/select-user/4";

        public gestionarClientes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarUsuarios gestionarUsuario = new gestionarUsuarios();
            this.Hide();
            gestionarUsuario.ShowDialog();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            cliente clientes = new cliente();
            this.Hide();
            clientes.ShowDialog();
        }

        private async void gestionarClientes_Load(object sender, EventArgs e)
        {
            string requestExterno = await GetHtppExterno();
            string requestLocal = await GetHtppLocal();
            string requestInterno = await GetHtppInterno();


            List<Usuarios> lstExternos = JsonConvert.DeserializeObject<List<Usuarios>>(requestExterno);
            List<Usuarios> lstLocales = JsonConvert.DeserializeObject<List<Usuarios>>(requestLocal);
            List<Usuarios> lstInternos = JsonConvert.DeserializeObject<List<Usuarios>>(requestInterno);

            var lstUsuarios = new List<Usuarios>();

            lstUsuarios.AddRange(lstExternos);
            lstUsuarios.AddRange(lstLocales);
            lstUsuarios.AddRange(lstInternos);

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
    }
}
