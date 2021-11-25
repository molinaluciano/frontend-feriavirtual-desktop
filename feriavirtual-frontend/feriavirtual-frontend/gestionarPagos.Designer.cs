
namespace feriavirtual_frontend
{
    partial class gestionarPagos
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
            this.dtgvGestionarPagos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdEstadoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridEstadoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridDetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOpcion1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Pagos";
            // 
            // dtgvGestionarPagos
            // 
            this.dtgvGestionarPagos.AllowUserToAddRows = false;
            this.dtgvGestionarPagos.AllowUserToDeleteRows = false;
            this.dtgvGestionarPagos.AllowUserToOrderColumns = true;
            this.dtgvGestionarPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvGestionarPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridIdVenta,
            this.dataGridIdSolicitud,
            this.dataGridIdEstadoVenta,
            this.dataGridEstadoVenta,
            this.dataGridIdTipoPago,
            this.dataGridDetalleVenta,
            this.dataGridOpcion1});
            this.dtgvGestionarPagos.Location = new System.Drawing.Point(148, 151);
            this.dtgvGestionarPagos.Name = "dtgvGestionarPagos";
            this.dtgvGestionarPagos.ReadOnly = true;
            this.dtgvGestionarPagos.Size = new System.Drawing.Size(671, 203);
            this.dtgvGestionarPagos.TabIndex = 1;
            this.dtgvGestionarPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGestionarPagos_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(380, 411);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(227, 51);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridIdVenta
            // 
            this.dataGridIdVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridIdVenta.DataPropertyName = "idVenta";
            this.dataGridIdVenta.HeaderText = "Id Venta Estado Finalizado";
            this.dataGridIdVenta.Name = "dataGridIdVenta";
            this.dataGridIdVenta.ReadOnly = true;
            // 
            // dataGridIdSolicitud
            // 
            this.dataGridIdSolicitud.DataPropertyName = "idSolicitud";
            this.dataGridIdSolicitud.HeaderText = "Id Solicitud";
            this.dataGridIdSolicitud.Name = "dataGridIdSolicitud";
            this.dataGridIdSolicitud.ReadOnly = true;
            // 
            // dataGridIdEstadoVenta
            // 
            this.dataGridIdEstadoVenta.DataPropertyName = "idEstadoVenta";
            this.dataGridIdEstadoVenta.HeaderText = "Id Estado Venta";
            this.dataGridIdEstadoVenta.Name = "dataGridIdEstadoVenta";
            this.dataGridIdEstadoVenta.ReadOnly = true;
            // 
            // dataGridEstadoVenta
            // 
            this.dataGridEstadoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridEstadoVenta.HeaderText = "Estado Venta";
            this.dataGridEstadoVenta.Name = "dataGridEstadoVenta";
            this.dataGridEstadoVenta.ReadOnly = true;
            // 
            // dataGridIdTipoPago
            // 
            this.dataGridIdTipoPago.DataPropertyName = "idTipoPago";
            this.dataGridIdTipoPago.HeaderText = "idTipoPago";
            this.dataGridIdTipoPago.Name = "dataGridIdTipoPago";
            this.dataGridIdTipoPago.ReadOnly = true;
            this.dataGridIdTipoPago.Visible = false;
            // 
            // dataGridDetalleVenta
            // 
            this.dataGridDetalleVenta.DataPropertyName = "detalleVenta";
            this.dataGridDetalleVenta.HeaderText = "Detalle Venta";
            this.dataGridDetalleVenta.Name = "dataGridDetalleVenta";
            this.dataGridDetalleVenta.ReadOnly = true;
            this.dataGridDetalleVenta.Visible = false;
            // 
            // dataGridOpcion1
            // 
            this.dataGridOpcion1.HeaderText = "Opcion_1";
            this.dataGridOpcion1.Name = "dataGridOpcion1";
            this.dataGridOpcion1.ReadOnly = true;
            this.dataGridOpcion1.Text = "Gestionar";
            this.dataGridOpcion1.UseColumnTextForButtonValue = true;
            // 
            // gestionarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvGestionarPagos);
            this.Controls.Add(this.label1);
            this.Name = "gestionarPagos";
            this.Text = "gestionarPagos";
            this.Load += new System.EventHandler(this.gestionarPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvGestionarPagos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdEstadoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridEstadoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridDetalleVenta;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOpcion1;
    }
}