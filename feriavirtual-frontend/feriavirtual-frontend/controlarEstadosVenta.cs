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
    public partial class controlarEstadosVenta : Form
    {
        public controlarEstadosVenta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarVentas gestionarVenta = new gestionarVentas();
            gestionarVenta.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionarVenta.FormBorderStyle = FormBorderStyle.None;
            gestionarVenta.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionarVenta);
            gestionarVenta.BringToFront();
            gestionarVenta.Show(); 
        }

        private void dtgvControlarEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
