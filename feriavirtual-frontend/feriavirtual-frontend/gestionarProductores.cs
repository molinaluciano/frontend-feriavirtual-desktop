using Newtonsoft.Json;
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

namespace feriavirtual_frontend
{
    public partial class gestionarProductores : Form
    {
        string url = "http://localhost:8080/select-producer";
        public gestionarProductores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarUsuarios gestionarUsuario = new gestionarUsuarios();
            this.Hide();
            gestionarUsuario.ShowDialog();
        }

        private async void gestionarProductores_Load(object sender, EventArgs e)
        {
            string requestProductor = await GetHtppProductor();

            List<Productores> lstProductores = JsonConvert.DeserializeObject<List<Productores>>(requestProductor);

            dtgvGestionarProductor.DataSource = lstProductores;
        }
        public async Task<string> GetHtppProductor()
        {
            WebRequest oRequestProductor = WebRequest.Create(url);
            WebResponse oResponseProductor = oRequestProductor.GetResponse();
            StreamReader srProductor = new StreamReader(oResponseProductor.GetResponseStream());
            return await srProductor.ReadToEndAsync();
        }

        private void btnNuevoProductor_Click(object sender, EventArgs e)
        {
            productores nuevoProductor = new productores();
            this.Hide();
            nuevoProductor.ShowDialog();
        }
    }
}
