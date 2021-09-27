using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using feriavirtual_frontend.Services;
using feriavirtual_frontend.Models;
using System.IO;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace feriavirtual_frontend
{
    public partial class LoginFeriaVirtual : Form
    {
        public LoginFeriaVirtual()
        {
            InitializeComponent();
            Console.WriteLine("postResult");
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("dnetro del metodo");
            string url = "http://localhost:8080/login";
            var client = new HttpClient();
            Usuarios user = new Usuarios(txtCorreo.Text, txtContrasena.Text, 1);

            var data = JsonSerializer.Serialize<Usuarios>(user);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync(url, content);
            Console.WriteLine(httpResponse);
            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                menuAdministrador menuAdministrador = new menuAdministrador();

                if (result == "ADMINISTRADOR")
                {
                    this.Hide();
                    menuAdministrador.ShowDialog();
                }
                Console.WriteLine(result);
            }
            else
            {
                MessageBox.Show("Usuario no válido");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
