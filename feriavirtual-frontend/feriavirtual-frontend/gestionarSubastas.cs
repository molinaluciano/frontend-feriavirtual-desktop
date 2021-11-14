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
    public partial class gestionarSubastas : Form
    {
        string urlSubasta = "http://localhost:8080/auctions";
        public gestionarSubastas()
        {
            InitializeComponent();
        }

        private async void gestionarSubastas_Load(object sender, EventArgs e)
        {
            string requestSubasta = await GetHtppSubasta();

            List<Subastas> lstSubastas = JsonConvert.DeserializeObject<List<Subastas>>(requestSubasta);

            dtgvGestionarSubastas.DataSource = lstSubastas;
        }
        public async Task<string> GetHtppSubasta()
        {
            WebRequest oRequestSubasta = WebRequest.Create(urlSubasta);
            WebResponse oResponseSubasta = oRequestSubasta.GetResponse();
            StreamReader srSubasta = new StreamReader(oResponseSubasta.GetResponseStream());

            return await srSubasta.ReadToEndAsync();
        }
    }
}
