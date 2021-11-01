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
    public partial class transportista : Form
    {
        public transportista()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarTransportista gestionarTransportistas = new gestionarTransportista();
            this.Hide();
            gestionarTransportistas.ShowDialog();
        }
    }
}
