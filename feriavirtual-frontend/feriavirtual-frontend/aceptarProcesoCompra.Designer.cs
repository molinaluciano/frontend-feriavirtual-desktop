
namespace feriavirtual_frontend
{
    partial class aceptarProcesoCompra
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtgvAceptarCompra = new System.Windows.Forms.DataGridView();
            this.dataGridNumeroSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdEstadoSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdTipoSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProductorSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridFechaPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOpcion1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridOpcion2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridOpcion3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAceptarCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aceptar Procesos de Compra";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(384, 407);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(219, 46);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtgvAceptarCompra
            // 
            this.dtgvAceptarCompra.AllowUserToAddRows = false;
            this.dtgvAceptarCompra.AllowUserToDeleteRows = false;
            this.dtgvAceptarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAceptarCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAceptarCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridNumeroSolicitud,
            this.dataGridNombreCliente,
            this.dataGridIdEstadoSolicitud,
            this.dataGridIdUsuario,
            this.dataGridIdTipoSolicitud,
            this.dataGridProductorSeleccionado,
            this.dataGridFechaPublicacion,
            this.dataGridOpcion1,
            this.dataGridOpcion2,
            this.dataGridOpcion3});
            this.dtgvAceptarCompra.Location = new System.Drawing.Point(88, 127);
            this.dtgvAceptarCompra.Name = "dtgvAceptarCompra";
            this.dtgvAceptarCompra.ReadOnly = true;
            this.dtgvAceptarCompra.Size = new System.Drawing.Size(808, 232);
            this.dtgvAceptarCompra.TabIndex = 2;
            this.dtgvAceptarCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAceptarCompra_CellContentClick);
            // 
            // dataGridNumeroSolicitud
            // 
            this.dataGridNumeroSolicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridNumeroSolicitud.DataPropertyName = "idSolicitud";
            this.dataGridNumeroSolicitud.HeaderText = "Número Solicitud";
            this.dataGridNumeroSolicitud.Name = "dataGridNumeroSolicitud";
            this.dataGridNumeroSolicitud.ReadOnly = true;
            this.dataGridNumeroSolicitud.Width = 103;
            // 
            // dataGridNombreCliente
            // 
            this.dataGridNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridNombreCliente.HeaderText = "Nombre Cliente";
            this.dataGridNombreCliente.Name = "dataGridNombreCliente";
            this.dataGridNombreCliente.ReadOnly = true;
            // 
            // dataGridIdEstadoSolicitud
            // 
            this.dataGridIdEstadoSolicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridIdEstadoSolicitud.DataPropertyName = "idEstadoSolicitud";
            this.dataGridIdEstadoSolicitud.HeaderText = "EstadoSolicitud";
            this.dataGridIdEstadoSolicitud.Name = "dataGridIdEstadoSolicitud";
            this.dataGridIdEstadoSolicitud.ReadOnly = true;
            this.dataGridIdEstadoSolicitud.Width = 105;
            // 
            // dataGridIdUsuario
            // 
            this.dataGridIdUsuario.DataPropertyName = "idUsuario";
            this.dataGridIdUsuario.HeaderText = "idUsuario";
            this.dataGridIdUsuario.Name = "dataGridIdUsuario";
            this.dataGridIdUsuario.ReadOnly = true;
            this.dataGridIdUsuario.Visible = false;
            // 
            // dataGridIdTipoSolicitud
            // 
            this.dataGridIdTipoSolicitud.DataPropertyName = "idTipoSolicitud";
            this.dataGridIdTipoSolicitud.HeaderText = "Tipo Solicitud";
            this.dataGridIdTipoSolicitud.Name = "dataGridIdTipoSolicitud";
            this.dataGridIdTipoSolicitud.ReadOnly = true;
            this.dataGridIdTipoSolicitud.Visible = false;
            // 
            // dataGridProductorSeleccionado
            // 
            this.dataGridProductorSeleccionado.DataPropertyName = "productorSeleccionado";
            this.dataGridProductorSeleccionado.HeaderText = "ProductorSeleccionado";
            this.dataGridProductorSeleccionado.Name = "dataGridProductorSeleccionado";
            this.dataGridProductorSeleccionado.ReadOnly = true;
            this.dataGridProductorSeleccionado.Visible = false;
            // 
            // dataGridFechaPublicacion
            // 
            this.dataGridFechaPublicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridFechaPublicacion.DataPropertyName = "fechaPublicacion";
            this.dataGridFechaPublicacion.HeaderText = "FechaPublicacion";
            this.dataGridFechaPublicacion.Name = "dataGridFechaPublicacion";
            this.dataGridFechaPublicacion.ReadOnly = true;
            // 
            // dataGridOpcion1
            // 
            this.dataGridOpcion1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridOpcion1.HeaderText = "Opcion_1";
            this.dataGridOpcion1.Name = "dataGridOpcion1";
            this.dataGridOpcion1.ReadOnly = true;
            this.dataGridOpcion1.Text = "Aceptar";
            this.dataGridOpcion1.UseColumnTextForButtonValue = true;
            this.dataGridOpcion1.Width = 59;
            // 
            // dataGridOpcion2
            // 
            this.dataGridOpcion2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridOpcion2.HeaderText = "Opcion_2";
            this.dataGridOpcion2.Name = "dataGridOpcion2";
            this.dataGridOpcion2.ReadOnly = true;
            this.dataGridOpcion2.Text = "Rechazar";
            this.dataGridOpcion2.UseColumnTextForButtonValue = true;
            this.dataGridOpcion2.Width = 59;
            // 
            // dataGridOpcion3
            // 
            this.dataGridOpcion3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridOpcion3.HeaderText = "Opcion_3";
            this.dataGridOpcion3.Name = "dataGridOpcion3";
            this.dataGridOpcion3.ReadOnly = true;
            this.dataGridOpcion3.Text = "Detalle";
            this.dataGridOpcion3.UseColumnTextForButtonValue = true;
            this.dataGridOpcion3.Width = 59;
            // 
            // aceptarProcesoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.dtgvAceptarCompra);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "aceptarProcesoCompra";
            this.Text = "aceptarProcesoCompra";
            this.Load += new System.EventHandler(this.aceptarProcesoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAceptarCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtgvAceptarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNumeroSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdEstadoSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdTipoSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridProductorSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridFechaPublicacion;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOpcion1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOpcion2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOpcion3;
    }
}