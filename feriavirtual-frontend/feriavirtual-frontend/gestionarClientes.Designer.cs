
namespace feriavirtual_frontend
{
    partial class gestionarClientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.dtgvGestionarClientes = new System.Windows.Forms.DataGridView();
            this.dataGridRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rut";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(81, 458);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(192, 34);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(503, 458);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(216, 34);
            this.btnNuevoCliente.TabIndex = 4;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 6;
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCliente.FormattingEnabled = true;
            this.cbxTipoCliente.Location = new System.Drawing.Point(517, 134);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(202, 24);
            this.cbxTipoCliente.TabIndex = 7;
            this.cbxTipoCliente.Text = "Tipo Cliente";
            // 
            // dtgvGestionarClientes
            // 
            this.dtgvGestionarClientes.AllowUserToAddRows = false;
            this.dtgvGestionarClientes.AllowUserToDeleteRows = false;
            this.dtgvGestionarClientes.AllowUserToOrderColumns = true;
            this.dtgvGestionarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridRut,
            this.dataGridNomCliente,
            this.dataGridOptions});
            this.dtgvGestionarClientes.Location = new System.Drawing.Point(81, 180);
            this.dtgvGestionarClientes.Name = "dtgvGestionarClientes";
            this.dtgvGestionarClientes.ReadOnly = true;
            this.dtgvGestionarClientes.Size = new System.Drawing.Size(638, 259);
            this.dtgvGestionarClientes.TabIndex = 8;
            // 
            // dataGridRut
            // 
            this.dataGridRut.HeaderText = "Rut";
            this.dataGridRut.Name = "dataGridRut";
            this.dataGridRut.ReadOnly = true;
            // 
            // dataGridNomCliente
            // 
            this.dataGridNomCliente.HeaderText = "Nombre Cliente";
            this.dataGridNomCliente.Name = "dataGridNomCliente";
            this.dataGridNomCliente.ReadOnly = true;
            // 
            // dataGridOptions
            // 
            this.dataGridOptions.HeaderText = "Options";
            this.dataGridOptions.Name = "dataGridOptions";
            this.dataGridOptions.ReadOnly = true;
            // 
            // gestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.dtgvGestionarClientes);
            this.Controls.Add(this.cbxTipoCliente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gestionarClientes";
            this.Text = "gestionarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.DataGridView dtgvGestionarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridOptions;
    }
}