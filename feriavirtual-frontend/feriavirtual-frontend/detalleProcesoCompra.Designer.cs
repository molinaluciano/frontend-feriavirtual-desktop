
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
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNombreSolicitud = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.dtgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.dataGridFruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(276, 434);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(235, 42);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle Proceso de Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Solicitud:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pedido:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(276, 111);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(263, 20);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // txtNombreSolicitud
            // 
            this.txtNombreSolicitud.Location = new System.Drawing.Point(276, 139);
            this.txtNombreSolicitud.Name = "txtNombreSolicitud";
            this.txtNombreSolicitud.Size = new System.Drawing.Size(263, 20);
            this.txtNombreSolicitud.TabIndex = 7;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(276, 168);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(263, 20);
            this.txtPais.TabIndex = 8;
            // 
            // dtgvDetalleCompra
            // 
            this.dtgvDetalleCompra.AllowUserToAddRows = false;
            this.dtgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dtgvDetalleCompra.AllowUserToOrderColumns = true;
            this.dtgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridFruta,
            this.dataGridCategoria,
            this.dataGridKg,
            this.dataGridCalidad});
            this.dtgvDetalleCompra.Location = new System.Drawing.Point(157, 215);
            this.dtgvDetalleCompra.Name = "dtgvDetalleCompra";
            this.dtgvDetalleCompra.ReadOnly = true;
            this.dtgvDetalleCompra.Size = new System.Drawing.Size(485, 185);
            this.dtgvDetalleCompra.TabIndex = 9;
            // 
            // dataGridFruta
            // 
            this.dataGridFruta.HeaderText = "Fruta";
            this.dataGridFruta.Name = "dataGridFruta";
            this.dataGridFruta.ReadOnly = true;
            // 
            // dataGridCategoria
            // 
            this.dataGridCategoria.HeaderText = "Categoria";
            this.dataGridCategoria.Name = "dataGridCategoria";
            this.dataGridCategoria.ReadOnly = true;
            // 
            // dataGridKg
            // 
            this.dataGridKg.HeaderText = "Kg";
            this.dataGridKg.Name = "dataGridKg";
            this.dataGridKg.ReadOnly = true;
            // 
            // dataGridCalidad
            // 
            this.dataGridCalidad.HeaderText = "Calidad";
            this.dataGridCalidad.Name = "dataGridCalidad";
            this.dataGridCalidad.ReadOnly = true;
            // 
            // detalleProcesoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.dtgvDetalleCompra);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNombreSolicitud);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Name = "detalleProcesoCompra";
            this.Text = "detalleProcesoCompra";
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
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNombreSolicitud;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.DataGridView dtgvDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCalidad;
    }
}