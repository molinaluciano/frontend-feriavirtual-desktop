
namespace feriavirtual_frontend
{
    partial class controlarEstadosVenta
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
            this.dtgvControlarEstados = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdEstadoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOpcion1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridEstadoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridDetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvControlarEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controlar Estados de Venta";
            // 
            // dtgvControlarEstados
            // 
            this.dtgvControlarEstados.AllowUserToAddRows = false;
            this.dtgvControlarEstados.AllowUserToDeleteRows = false;
            this.dtgvControlarEstados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvControlarEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvControlarEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridIdVenta,
            this.dataGridIdSolicitud,
            this.dataGridIdEstadoVenta,
            this.dataGridIdTipoPago,
            this.dataGridNomCliente,
            this.dataGridOpcion1,
            this.dataGridEstadoVenta,
            this.dataGridDetalleVenta});
            this.dtgvControlarEstados.Location = new System.Drawing.Point(131, 139);
            this.dtgvControlarEstados.Name = "dtgvControlarEstados";
            this.dtgvControlarEstados.ReadOnly = true;
            this.dtgvControlarEstados.Size = new System.Drawing.Size(746, 210);
            this.dtgvControlarEstados.TabIndex = 1;
            this.dtgvControlarEstados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvControlarEstados_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(390, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(205, 50);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridIdVenta
            // 
            this.dataGridIdVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridIdVenta.DataPropertyName = "idVenta";
            this.dataGridIdVenta.HeaderText = "Id Venta";
            this.dataGridIdVenta.Name = "dataGridIdVenta";
            this.dataGridIdVenta.ReadOnly = true;
            this.dataGridIdVenta.Width = 72;
            // 
            // dataGridIdSolicitud
            // 
            this.dataGridIdSolicitud.DataPropertyName = "idSolicitud";
            this.dataGridIdSolicitud.HeaderText = "IdSolicitud";
            this.dataGridIdSolicitud.Name = "dataGridIdSolicitud";
            this.dataGridIdSolicitud.ReadOnly = true;
            // 
            // dataGridIdEstadoVenta
            // 
            this.dataGridIdEstadoVenta.DataPropertyName = "idEstadoVenta";
            this.dataGridIdEstadoVenta.HeaderText = "IdEstadoVenta";
            this.dataGridIdEstadoVenta.Name = "dataGridIdEstadoVenta";
            this.dataGridIdEstadoVenta.ReadOnly = true;
            // 
            // dataGridIdTipoPago
            // 
            this.dataGridIdTipoPago.DataPropertyName = "idTipoPago";
            this.dataGridIdTipoPago.HeaderText = "IdTipoPago";
            this.dataGridIdTipoPago.Name = "dataGridIdTipoPago";
            this.dataGridIdTipoPago.ReadOnly = true;
            this.dataGridIdTipoPago.Visible = false;
            // 
            // dataGridNomCliente
            // 
            this.dataGridNomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridNomCliente.HeaderText = "Nombre Cliente";
            this.dataGridNomCliente.Name = "dataGridNomCliente";
            this.dataGridNomCliente.ReadOnly = true;
            // 
            // dataGridOpcion1
            // 
            this.dataGridOpcion1.HeaderText = "Controlar Estado";
            this.dataGridOpcion1.Name = "dataGridOpcion1";
            this.dataGridOpcion1.ReadOnly = true;
            this.dataGridOpcion1.Text = "Cambiar";
            this.dataGridOpcion1.UseColumnTextForButtonValue = true;
            // 
            // dataGridEstadoVenta
            // 
            this.dataGridEstadoVenta.HeaderText = "EstadoVenta";
            this.dataGridEstadoVenta.Name = "dataGridEstadoVenta";
            this.dataGridEstadoVenta.ReadOnly = true;
            // 
            // dataGridDetalleVenta
            // 
            this.dataGridDetalleVenta.DataPropertyName = "detalleVenta";
            this.dataGridDetalleVenta.HeaderText = "Detalle Venta";
            this.dataGridDetalleVenta.Name = "dataGridDetalleVenta";
            this.dataGridDetalleVenta.ReadOnly = true;
            this.dataGridDetalleVenta.Visible = false;
            // 
            // controlarEstadosVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvControlarEstados);
            this.Controls.Add(this.label1);
            this.Name = "controlarEstadosVenta";
            this.Text = "controlarEstadosVenta";
            this.Load += new System.EventHandler(this.controlarEstadosVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvControlarEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvControlarEstados;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdEstadoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNomCliente;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOpcion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridEstadoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridDetalleVenta;
    }
}