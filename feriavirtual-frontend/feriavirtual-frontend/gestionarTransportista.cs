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
    public partial class gestionarTransportista : Form
    {
        public gestionarTransportista()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarUsuarios gestionarUsuario = new gestionarUsuarios();
            this.Hide();
            gestionarUsuario.ShowDialog();
        }

        private void btnNuevoTransportista_Click(object sender, EventArgs e)
        {
            transportista transportistas = new transportista();
            this.Hide();
            transportistas.ShowDialog();
        }
    }
}
