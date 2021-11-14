
namespace feriavirtual_frontend
{
    partial class gestionarSubastas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvGestionarSubastas = new System.Windows.Forms.DataGridView();
            this.dataGridIdSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdEstadoSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridFechaPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridFechaTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCamionSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarSubastas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Subastas";
            // 
            // dtgvGestionarSubastas
            // 
            this.dtgvGestionarSubastas.AllowUserToAddRows = false;
            this.dtgvGestionarSubastas.AllowUserToDeleteRows = false;
            this.dtgvGestionarSubastas.AllowUserToOrderColumns = true;
            this.dtgvGestionarSubastas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvGestionarSubastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarSubastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridIdSubasta,
            this.dataGridIdSolicitud,
            this.dataGridNomCliente,
            this.dataGridIdEstadoSubasta,
            this.dataGridFechaPublicacion,
            this.dataGridFechaTermino,
            this.dataGridCamionSeleccionado});
            this.dtgvGestionarSubastas.Location = new System.Drawing.Point(112, 145);
            this.dtgvGestionarSubastas.Name = "dtgvGestionarSubastas";
            this.dtgvGestionarSubastas.ReadOnly = true;
            this.dtgvGestionarSubastas.Size = new System.Drawing.Size(763, 222);
            this.dtgvGestionarSubastas.TabIndex = 3;
            // 
            // dataGridIdSubasta
            // 
            this.dataGridIdSubasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridIdSubasta.DataPropertyName = "idSubasta";
            this.dataGridIdSubasta.HeaderText = "Id Subasta";
            this.dataGridIdSubasta.Name = "dataGridIdSubasta";
            this.dataGridIdSubasta.ReadOnly = true;
            this.dataGridIdSubasta.Width = 83;
            // 
            // dataGridIdSolicitud
            // 
            this.dataGridIdSolicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridIdSolicitud.DataPropertyName = "idSolicitud";
            this.dataGridIdSolicitud.HeaderText = "Id Solicitud";
            this.dataGridIdSolicitud.Name = "dataGridIdSolicitud";
            this.dataGridIdSolicitud.ReadOnly = true;
            this.dataGridIdSolicitud.Width = 84;
            // 
            // dataGridNomCliente
            // 
            this.dataGridNomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridNomCliente.HeaderText = "Nombre Cliente";
            this.dataGridNomCliente.Name = "dataGridNomCliente";
            this.dataGridNomCliente.ReadOnly = true;
            // 
            // dataGridIdEstadoSubasta
            // 
            this.dataGridIdEstadoSubasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridIdEstadoSubasta.DataPropertyName = "idEstadoSubasta";
            this.dataGridIdEstadoSubasta.HeaderText = "IdEstadoSubasta";
            this.dataGridIdEstadoSubasta.Name = "dataGridIdEstadoSubasta";
            this.dataGridIdEstadoSubasta.ReadOnly = true;
            this.dataGridIdEstadoSubasta.Width = 113;
            // 
            // dataGridFechaPublicacion
            // 
            this.dataGridFechaPublicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridFechaPublicacion.DataPropertyName = "fechaPublicacion";
            this.dataGridFechaPublicacion.HeaderText = "Fecha Publicacion";
            this.dataGridFechaPublicacion.Name = "dataGridFechaPublicacion";
            this.dataGridFechaPublicacion.ReadOnly = true;
            // 
            // dataGridFechaTermino
            // 
            this.dataGridFechaTermino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridFechaTermino.DataPropertyName = "fechaTermino";
            this.dataGridFechaTermino.HeaderText = "Fecha Termino";
            this.dataGridFechaTermino.Name = "dataGridFechaTermino";
            this.dataGridFechaTermino.ReadOnly = true;
            // 
            // dataGridCamionSeleccionado
            // 
            this.dataGridCamionSeleccionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridCamionSeleccionado.DataPropertyName = "camionSeleccionado";
            this.dataGridCamionSeleccionado.HeaderText = "Camion Seleccionado";
            this.dataGridCamionSeleccionado.Name = "dataGridCamionSeleccionado";
            this.dataGridCamionSeleccionado.ReadOnly = true;
            this.dataGridCamionSeleccionado.Width = 123;
            // 
            // gestionarSubastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.dtgvGestionarSubastas);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "gestionarSubastas";
            this.Text = "gestionarSubastas";
            this.Load += new System.EventHandler(this.gestionarSubastas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarSubastas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvGestionarSubastas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdEstadoSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridFechaPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridFechaTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCamionSeleccionado;
    }
}