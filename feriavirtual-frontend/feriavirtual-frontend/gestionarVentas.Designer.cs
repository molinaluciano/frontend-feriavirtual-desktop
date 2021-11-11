
namespace feriavirtual_frontend
{
    partial class gestionarVentas
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
            this.btnAceptarCompra = new System.Windows.Forms.Button();
            this.btnControlarEstados = new System.Windows.Forms.Button();
            this.btnGestionarPagos = new System.Windows.Forms.Button();
            this.btnIngresarSaldos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Ventas";
            // 
            // btnAceptarCompra
            // 
            this.btnAceptarCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(145)))));
            this.btnAceptarCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCompra.ForeColor = System.Drawing.Color.Silver;
            this.btnAceptarCompra.Location = new System.Drawing.Point(317, 163);
            this.btnAceptarCompra.Name = "btnAceptarCompra";
            this.btnAceptarCompra.Size = new System.Drawing.Size(363, 85);
            this.btnAceptarCompra.TabIndex = 1;
            this.btnAceptarCompra.Text = "Aceptar Procesos de Compra";
            this.btnAceptarCompra.UseVisualStyleBackColor = false;
            this.btnAceptarCompra.Click += new System.EventHandler(this.btnAceptarCompra_Click);
            // 
            // btnControlarEstados
            // 
            this.btnControlarEstados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnControlarEstados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(145)))));
            this.btnControlarEstados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlarEstados.ForeColor = System.Drawing.Color.Silver;
            this.btnControlarEstados.Location = new System.Drawing.Point(317, 254);
            this.btnControlarEstados.Name = "btnControlarEstados";
            this.btnControlarEstados.Size = new System.Drawing.Size(363, 85);
            this.btnControlarEstados.TabIndex = 2;
            this.btnControlarEstados.Text = "Controlar Estados de Ventas";
            this.btnControlarEstados.UseVisualStyleBackColor = false;
            this.btnControlarEstados.Click += new System.EventHandler(this.btnControlarEstados_Click);
            // 
            // btnGestionarPagos
            // 
            this.btnGestionarPagos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGestionarPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(145)))));
            this.btnGestionarPagos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPagos.ForeColor = System.Drawing.Color.Silver;
            this.btnGestionarPagos.Location = new System.Drawing.Point(317, 345);
            this.btnGestionarPagos.Name = "btnGestionarPagos";
            this.btnGestionarPagos.Size = new System.Drawing.Size(363, 85);
            this.btnGestionarPagos.TabIndex = 3;
            this.btnGestionarPagos.Text = "Gestionar Pagos";
            this.btnGestionarPagos.UseVisualStyleBackColor = false;
            this.btnGestionarPagos.Click += new System.EventHandler(this.btnGestionarPagos_Click);
            // 
            // btnIngresarSaldos
            // 
            this.btnIngresarSaldos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresarSaldos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(145)))));
            this.btnIngresarSaldos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarSaldos.ForeColor = System.Drawing.Color.Silver;
            this.btnIngresarSaldos.Location = new System.Drawing.Point(317, 436);
            this.btnIngresarSaldos.Name = "btnIngresarSaldos";
            this.btnIngresarSaldos.Size = new System.Drawing.Size(363, 85);
            this.btnIngresarSaldos.TabIndex = 4;
            this.btnIngresarSaldos.Text = "Ingresar Saldos";
            this.btnIngresarSaldos.UseVisualStyleBackColor = false;
            this.btnIngresarSaldos.Click += new System.EventHandler(this.btnIngresarSaldos_Click);
            // 
            // gestionarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.btnIngresarSaldos);
            this.Controls.Add(this.btnGestionarPagos);
            this.Controls.Add(this.btnControlarEstados);
            this.Controls.Add(this.btnAceptarCompra);
            this.Controls.Add(this.label1);
            this.Name = "gestionarVentas";
            this.Text = "gestionarVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarCompra;
        private System.Windows.Forms.Button btnControlarEstados;
        private System.Windows.Forms.Button btnGestionarPagos;
        private System.Windows.Forms.Button btnIngresarSaldos;
    }
}