﻿using Newtonsoft.Json;
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
using System.Net.Http;

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
            string requestProductor ="";
            try
            {
                requestProductor = await GetHtppProductor();
            }
            catch (WebException err)
            {
                Console.WriteLine(err);
            }

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

        private async void dtgvGestionarProductor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvGestionarProductor.Columns[e.ColumnIndex].Name == "dataGridOpcion1")
            {
                int idUsuario = Int32.Parse(dtgvGestionarProductor.CurrentRow.Cells["dataGridIdUsuario"].Value.ToString());
                editarProductor editar = new editarProductor(idUsuario);
                this.Hide();
                editar.ShowDialog();

            }
            if(dtgvGestionarProductor.Columns[e.ColumnIndex].Name == "dataGridOpcion2")
            {
                var eliminarProductor = new HttpClient();

                Productores deleteProductor = new Productores(Int32.Parse(dtgvGestionarProductor.CurrentRow.Cells["dataGridIdUsuario"].Value.ToString()), 6);

                var data = System.Text.Json.JsonSerializer.Serialize<Productores>(deleteProductor);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                //var httpResponse = await eliminarCliente.DeleteAsync(urlDelete + content);

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri("http://localhost:8080/delete-user"),
                    Content = content
                };

                var httpResponse = await eliminarProductor.SendAsync(request);

                if (httpResponse.IsSuccessStatusCode && (MessageBox.Show("Seguro Desea eliminar este Productor?", "Eliminar Productor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    MessageBox.Show("Productor Eliminado correctamente");
                    gestionarProductores gestionar = new gestionarProductores();
                    this.Hide();
                    gestionar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error Productor no puedo ser eliminado");
                }
            }
        }
    }
}
