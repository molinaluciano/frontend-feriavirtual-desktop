
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
            this.dataGridIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 38);
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
            this.dtgvGestionarPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridIdVenta,
            this.dataGridOptions});
            this.dtgvGestionarPagos.Location = new System.Drawing.Point(133, 117);
            this.dtgvGestionarPagos.Name = "dtgvGestionarPagos";
            this.dtgvGestionarPagos.ReadOnly = true;
            this.dtgvGestionarPagos.Size = new System.Drawing.Size(520, 203);
            this.dtgvGestionarPagos.TabIndex = 1;
            // 
            // dataGridIdVenta
            // 
            this.dataGridIdVenta.HeaderText = "Id Venta Estado Finalizado";
            this.dataGridIdVenta.Name = "dataGridIdVenta";
            this.dataGridIdVenta.ReadOnly = true;
            // 
            // dataGridOptions
            // 
            this.dataGridOptions.HeaderText = "Options";
            this.dataGridOptions.Name = "dataGridOptions";
            this.dataGridOptions.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(290, 360);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(193, 46);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gestionarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvGestionarPagos);
            this.Controls.Add(this.label1);
            this.Name = "gestionarPagos";
            this.Text = "gestionarPagos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvGestionarPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridOptions;
        private System.Windows.Forms.Button btnVolver;
    }
}