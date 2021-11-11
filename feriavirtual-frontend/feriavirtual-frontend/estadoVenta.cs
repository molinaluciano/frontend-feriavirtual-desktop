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
    public partial class estadoVenta : Form
    {
        public estadoVenta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            controlarEstadosVenta controlarEstados = new controlarEstadosVenta();
            controlarEstados.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            controlarEstados.FormBorderStyle = FormBorderStyle.None;
            controlarEstados.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(controlarEstados);
            controlarEstados.BringToFront();
            controlarEstados.Show();
        }
    }
}
