
namespace feriavirtual_frontend
{
    partial class detalleProcesoCompra
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.lbNomCliente = new System.Windows.Forms.Label();
            this.lbTipoSolicitud = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbPedido = new System.Windows.Forms.Label();
            this.dataGridFruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(386, 440);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(235, 51);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle Proceso de Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Solicitud:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pedido:";
            // 
            // dtgvDetalleCompra
            // 
            this.dtgvDetalleCompra.AllowUserToAddRows = false;
            this.dtgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dtgvDetalleCompra.AllowUserToOrderColumns = true;
            this.dtgvDetalleCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridFruta,
            this.dataGridCategoria,
            this.dataGridKg,
            this.dataGridCalidad});
            this.dtgvDetalleCompra.Location = new System.Drawing.Point(97, 221);
            this.dtgvDetalleCompra.Name = "dtgvDetalleCompra";
            this.dtgvDetalleCompra.ReadOnly = true;
            this.dtgvDetalleCompra.Size = new System.Drawing.Size(783, 185);
            this.dtgvDetalleCompra.TabIndex = 9;
            // 
            // lbNomCliente
            // 
            this.lbNomCliente.AutoSize = true;
            this.lbNomCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomCliente.Location = new System.Drawing.Point(253, 102);
            this.lbNomCliente.Name = "lbNomCliente";
            this.lbNomCliente.Size = new System.Drawing.Size(106, 21);
            this.lbNomCliente.TabIndex = 10;
            this.lbNomCliente.Text = "nom_cliente";
            // 
            // lbTipoSolicitud
            // 
            this.lbTipoSolicitud.AutoSize = true;
            this.lbTipoSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoSolicitud.Location = new System.Drawing.Point(253, 130);
            this.lbTipoSolicitud.Name = "lbTipoSolicitud";
            this.lbTipoSolicitud.Size = new System.Drawing.Size(112, 21);
            this.lbTipoSolicitud.TabIndex = 11;
            this.lbTipoSolicitud.Text = "tipo_solicitud";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPais.Location = new System.Drawing.Point(253, 155);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(41, 21);
            this.lbPais.TabIndex = 12;
            this.lbPais.Text = "pais";
            // 
            // lbPedido
            // 
            this.lbPedido.AutoSize = true;
            this.lbPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedido.Location = new System.Drawing.Point(253, 181);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(66, 21);
            this.lbPedido.TabIndex = 13;
            this.lbPedido.Text = "pedido";
            // 
            // dataGridFruta
            // 
            this.dataGridFruta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridFruta.HeaderText = "Fruta";
            this.dataGridFruta.Name = "dataGridFruta";
            this.dataGridFruta.ReadOnly = true;
            // 
            // dataGridCategoria
            // 
            this.dataGridCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridCategoria.HeaderText = "Categoria";
            this.dataGridCategoria.Name = "dataGridCategoria";
            this.dataGridCategoria.ReadOnly = true;
            // 
            // dataGridKg
            // 
            this.dataGridKg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridKg.HeaderText = "Kg";
            this.dataGridKg.Name = "dataGridKg";
            this.dataGridKg.ReadOnly = true;
            // 
            // dataGridCalidad
            // 
            this.dataGridCalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridCalidad.HeaderText = "Calidad";
            this.dataGridCalidad.Name = "dataGridCalidad";
            this.dataGridCalidad.ReadOnly = true;
            // 
            // detalleProcesoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.lbPedido);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.lbTipoSolicitud);
            this.Controls.Add(this.lbNomCliente);
            this.Controls.Add(this.dtgvDetalleCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Name = "detalleProcesoCompra";
            this.Text = "detalleProcesoCompra";
            this.Load += new System.EventHandler(this.detalleProcesoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCalidad;
        private System.Windows.Forms.Label lbNomCliente;
        private System.Windows.Forms.Label lbTipoSolicitud;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbPedido;
    }
}