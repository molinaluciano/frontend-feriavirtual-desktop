using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            gestionarProductor.ShowDialog();
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            gestionarClientes gestionarCliente = new gestionarClientes();
            this.Hide();
            gestionarCliente.ShowDialog();
        }

        private void btnGestionarTransportistas_Click(object sender, EventArgs e)
        {
            gestionarTransportista gestionarTransportistas = new gestionarTransportista();
            this.Hide();
            gestionarTransportistas.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuAdministrador menuAdmin = new menuAdministrador();
            this.Hide();
            menuAdmin.ShowDialog();
        }
    }
}
