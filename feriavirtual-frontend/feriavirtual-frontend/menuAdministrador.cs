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
        //Fields
        private Button currentButton;
        private Form activeForm;
        
        public menuAdministrador()
        {
            InitializeComponent();
        }

        public void activateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    disableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor =  Color.FromArgb(51, 76, 64);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = Color.FromArgb(51, 76, 64);
                }
            }
        }

        public void disableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void openChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new gestionarUsuarios(), sender) ;
        }

        private void btnGestionarVentas_Click(object sender, EventArgs e)
        {
            openChildForm(new gestionarVentas(), sender);
        }

        private void btnGestionarInformes_Click(object sender, EventArgs e)
        {
            openChildForm(new gestionarInformes(), sender);
        }

        private void btnGestionarSubastas_Click(object sender, EventArgs e)
        {
            openChildForm(new gestionarSubastas(), sender);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginFeriaVirtual principal = new LoginFeriaVirtual();
            this.Hide();
            principal.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(label2);
            panelDesktop.Controls.Add(label3);
            panelDesktop.Controls.Add(pictureBox1);
        }
    }
}
