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
    public partial class menuAdministrador : Form
    {
        public menuAdministrador()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginFeriaVirtual principal = new LoginFeriaVirtual();
            this.Hide();
            principal.ShowDialog();
        }
    }
}
