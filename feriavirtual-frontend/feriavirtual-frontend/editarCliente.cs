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
    public partial class editarCliente : Form
    {
        private int selectedIdUsuario;
        public editarCliente(int idUsuario)
        {
            InitializeComponent();
            this.selectedIdUsuario = idUsuario;
        }

        string urlExterno = "http://localhost:8080/select-user/2";
        string urlLocal = "http://localhost:8080/select-user/3";
        string urlInterno = "http://localhost:8080/select-user/4";
        string urlUpdate = "http://localhost:8080/update-user";
        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarClientes gestionarCliente = new gestionarClientes();
            this.Hide();
            gestionarCliente.ShowDialog();
        }

        private async void editarCliente_Load(object sender, EventArgs e)
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

            Usuarios usuario = new Usuarios();

            usuario = lstUsuarios.Find( storedUsuario => storedUsuario.idUsuario.Value == selectedIdUsuario);

            txtNombres.Text = usuario.nombre;
            txtApellidoPaterno.Text = usuario.apellidoPaterno;
            txtApellidoMaterno.Text = usuario.apellidoMaterno;
            txtContrasena.Text = usuario.contrasena;
            txtCorreo.Text = usuario.correo;
            txtRut.Text = usuario.rut.ToString();
            txtNumeroIdentificador.Text = usuario.numeroIdentificador;
            txtCodigoPostal.Text = usuario.codigoPostal.ToString();
            txtDireccion.Text = usuario.direccion;
            txtTelefono.Text = usuario.telefono.ToString();
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

        public async Task<string> GetHtppUpdateUsuario()
        {
            WebRequest oRequestUpdateUsuario = WebRequest.Create(urlUpdate);
            WebResponse oResponseUpdateUsuario = oRequestUpdateUsuario.GetResponse();
            StreamReader srUpdateUsuario = new StreamReader(oResponseUpdateUsuario.GetResponseStream());
            return await srUpdateUsuario.ReadToEndAsync();
        }

        private async void btnEditarCliente_Click(object sender, EventArgs e)
        {
            var updateUsuario = new HttpClient();

            Usuarios usuario = new Usuarios()
            {
                idTipoUsuario = null,
                idPais = null,
                idUsuario = null,
                nombre = txtNombres.Text,
                apellidoPaterno = txtApellidoPaterno.Text,
                apellidoMaterno = txtApellidoMaterno.Text,
                correo = txtCorreo.Text,
                contrasena = txtContrasena.Text,
                rut = Int32.Parse(txtRut.Text),
                numeroIdentificador = txtNumeroIdentificador.Text,
                direccion = txtDireccion.Text,
                codigoPostal = Int32.Parse(txtCodigoPostal.Text),
                telefono = Int32.Parse(txtTelefono.Text),
            };

            var data = System.Text.Json.JsonSerializer.Serialize<Usuarios>(usuario);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await updateUsuario.PutAsync(urlUpdate, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                MessageBox.Show("Usuario Editado Correctamente");

                gestionarClientes gestionarC = new gestionarClientes();
                this.Hide();
                gestionarC.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error Usuario no puedo ser editado");
            }
        }
    }
}
