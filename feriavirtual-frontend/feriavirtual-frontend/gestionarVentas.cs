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
    public partial class gestionarVentas : Form
    {
        public gestionarVentas()
        {
            InitializeComponent();
        }

        private void btnAceptarCompra_Click(object sender, EventArgs e)
        {
            aceptarProcesoCompra aceptarCompra = new aceptarProcesoCompra();
            aceptarCompra.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            aceptarCompra.FormBorderStyle = FormBorderStyle.None;
            aceptarCompra.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(aceptarCompra);
            aceptarCompra.BringToFront();
            aceptarCompra.Show();
        }

        private void btnControlarEstados_Click(object sender, EventArgs e)
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

        private void btnGestionarPagos_Click(object sender, EventArgs e)
        {
            gestionarPagos gestionarPago = new gestionarPagos();
            gestionarPago.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            gestionarPago.FormBorderStyle = FormBorderStyle.None;
            gestionarPago.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(gestionarPago);
            gestionarPago.BringToFront();
            gestionarPago.Show(); 
        }

        private void btnIngresarSaldos_Click(object sender, EventArgs e)
        {
            ingresarSaldos ingresarSaldo = new ingresarSaldos();
            ingresarSaldo.TopLevel = false;

            menuAdministrador menu = (menuAdministrador)Application.OpenForms["menuAdministrador"];
            Panel panelDesktop = (Panel)menu.Controls["panelDesktop"];
            ingresarSaldo.FormBorderStyle = FormBorderStyle.None;
            ingresarSaldo.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ingresarSaldo);
            ingresarSaldo.BringToFront();
            ingresarSaldo.Show(); 
        }
    }
}
