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
    public partial class gestionarClientes : Form
    {
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
    }
}
