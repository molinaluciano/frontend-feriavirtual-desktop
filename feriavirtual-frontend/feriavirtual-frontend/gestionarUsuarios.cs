using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using feriavirtual_frontend;

namespace feriavirtual_frontend
{
    public partial class gestionarUsuarios : Form
    {
        public gestionarUsuarios()
        {
            InitializeComponent();
        }

        private void btnGestionarProductores_Click(object sender, EventArgs e)
        {
            gestionarProductores gestionarProductor = new gestionarProductores();
            gestionarProductor.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionarProductor.FormBorderStyle = FormBorderStyle.None;
            gestionarProductor.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionarProductor);
            gestionarProductor.BringToFront();
            gestionarProductor.Show();
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
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

        private void btnGestionarTransportistas_Click(object sender, EventArgs e)
        {
            gestionarTransportista gestionarTransportistas = new gestionarTransportista();
            gestionarTransportistas.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionarTransportistas.FormBorderStyle = FormBorderStyle.None;
            gestionarTransportistas.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionarTransportistas);
            gestionarTransportistas.BringToFront();
            gestionarTransportistas.Show();
        }

    }
}
