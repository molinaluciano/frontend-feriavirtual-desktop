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
            this.Hide();
            aceptarCompra.ShowDialog();
        }

        private void btnControlarEstados_Click(object sender, EventArgs e)
        {
            controlarEstadosVenta controlarEstados = new controlarEstadosVenta();
            this.Hide();
            controlarEstados.ShowDialog();
        }

        private void btnGestionarPagos_Click(object sender, EventArgs e)
        {
            gestionarPagos gestionarPago = new gestionarPagos();
            this.Hide();
            gestionarPago.ShowDialog();
        }

        private void btnIngresarSaldos_Click(object sender, EventArgs e)
        {
            ingresarSaldos ingresarSaldo = new ingresarSaldos();
            this.Hide();
            ingresarSaldo.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuAdministrador menuAdmin = new menuAdministrador();
            this.Hide();
            menuAdmin.ShowDialog();
        }
    }
}
