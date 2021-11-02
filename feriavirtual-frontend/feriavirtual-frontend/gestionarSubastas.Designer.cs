
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCrearSubasta = new System.Windows.Forms.Button();
            this.dtgvGestionarSubastas = new System.Windows.Forms.DataGridView();
            this.dataGridIdSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarSubastas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Subastas";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(107, 385);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 36);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCrearSubasta
            // 
            this.btnCrearSubasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearSubasta.Location = new System.Drawing.Point(540, 385);
            this.btnCrearSubasta.Name = "btnCrearSubasta";
            this.btnCrearSubasta.Size = new System.Drawing.Size(157, 36);
            this.btnCrearSubasta.TabIndex = 2;
            this.btnCrearSubasta.Text = "Crear Subasta";
            this.btnCrearSubasta.UseVisualStyleBackColor = true;
            // 
            // dtgvGestionarSubastas
            // 
            this.dtgvGestionarSubastas.AllowUserToAddRows = false;
            this.dtgvGestionarSubastas.AllowUserToDeleteRows = false;
            this.dtgvGestionarSubastas.AllowUserToOrderColumns = true;
            this.dtgvGestionarSubastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarSubastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridIdSubasta,
            this.dataGridNomCliente,
            this.dataGridOptions});
            this.dtgvGestionarSubastas.Location = new System.Drawing.Point(107, 140);
            this.dtgvGestionarSubastas.Name = "dtgvGestionarSubastas";
            this.dtgvGestionarSubastas.ReadOnly = true;
            this.dtgvGestionarSubastas.Size = new System.Drawing.Size(590, 222);
            this.dtgvGestionarSubastas.TabIndex = 3;
            // 
            // dataGridIdSubasta
            // 
            this.dataGridIdSubasta.HeaderText = "Id Subasta";
            this.dataGridIdSubasta.Name = "dataGridIdSubasta";
            this.dataGridIdSubasta.ReadOnly = true;
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
            // gestionarSubastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvGestionarSubastas);
            this.Controls.Add(this.btnCrearSubasta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "gestionarSubastas";
            this.Text = "gestionarSubastas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarSubastas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCrearSubasta;
        private System.Windows.Forms.DataGridView dtgvGestionarSubastas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridOptions;
    }
}