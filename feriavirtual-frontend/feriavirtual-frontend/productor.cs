﻿using System;
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
    public partial class productor : Form
    {
        private void btnVolver_Click(object sender, EventArgs e)
        {
            gestionarProductores gestionarProductor = new gestionarProductores();
            this.Hide();
            gestionarProductor.ShowDialog();
        }
    }
}
