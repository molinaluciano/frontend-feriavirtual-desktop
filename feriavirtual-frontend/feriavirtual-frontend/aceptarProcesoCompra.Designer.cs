
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
            this.dataGridOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAceptarCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aceptar Procesos de Compra";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(303, 365);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(219, 36);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtgvAceptarCompra
            // 
            this.dtgvAceptarCompra.AllowUserToAddRows = false;
            this.dtgvAceptarCompra.AllowUserToDeleteRows = false;
            this.dtgvAceptarCompra.AllowUserToOrderColumns = true;
            this.dtgvAceptarCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAceptarCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridNumeroSolicitud,
            this.dataGridNombreCliente,
            this.dataGridOptions});
            this.dtgvAceptarCompra.Location = new System.Drawing.Point(115, 113);
            this.dtgvAceptarCompra.Name = "dtgvAceptarCompra";
            this.dtgvAceptarCompra.ReadOnly = true;
            this.dtgvAceptarCompra.Size = new System.Drawing.Size(588, 232);
            this.dtgvAceptarCompra.TabIndex = 2;
            // 
            // dataGridNumeroSolicitud
            // 
            this.dataGridNumeroSolicitud.HeaderText = "Número Solicitud";
            this.dataGridNumeroSolicitud.Name = "dataGridNumeroSolicitud";
            this.dataGridNumeroSolicitud.ReadOnly = true;
            // 
            // dataGridNombreCliente
            // 
            this.dataGridNombreCliente.HeaderText = "Nombre Cliente";
            this.dataGridNombreCliente.Name = "dataGridNombreCliente";
            this.dataGridNombreCliente.ReadOnly = true;
            // 
            // dataGridOptions
            // 
            this.dataGridOptions.HeaderText = "Options";
            this.dataGridOptions.Name = "dataGridOptions";
            this.dataGridOptions.ReadOnly = true;
            // 
            // aceptarProcesoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvAceptarCompra);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "aceptarProcesoCompra";
            this.Text = "aceptarProcesoCompra";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridOptions;
    }
}