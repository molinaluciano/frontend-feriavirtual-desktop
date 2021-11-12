
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
            this.dtgvGestionarSubastas = new System.Windows.Forms.DataGridView();
            this.dataGridIdSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarSubastas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Subastas";
            // 
            // dtgvGestionarSubastas
            // 
            this.dtgvGestionarSubastas.AllowUserToAddRows = false;
            this.dtgvGestionarSubastas.AllowUserToDeleteRows = false;
            this.dtgvGestionarSubastas.AllowUserToOrderColumns = true;
            this.dtgvGestionarSubastas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvGestionarSubastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarSubastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridIdSubasta,
            this.dataGridNomCliente,
            this.dataGridOptions});
            this.dtgvGestionarSubastas.Location = new System.Drawing.Point(112, 145);
            this.dtgvGestionarSubastas.Name = "dtgvGestionarSubastas";
            this.dtgvGestionarSubastas.ReadOnly = true;
            this.dtgvGestionarSubastas.Size = new System.Drawing.Size(763, 222);
            this.dtgvGestionarSubastas.TabIndex = 3;
            // 
            // dataGridIdSubasta
            // 
            this.dataGridIdSubasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridIdSubasta.HeaderText = "Id Subasta";
            this.dataGridIdSubasta.Name = "dataGridIdSubasta";
            this.dataGridIdSubasta.ReadOnly = true;
            // 
            // dataGridNomCliente
            // 
            this.dataGridNomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.dtgvGestionarSubastas);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "gestionarSubastas";
            this.Text = "gestionarSubastas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarSubastas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvGestionarSubastas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridOptions;
    }
}