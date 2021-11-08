
namespace feriavirtual_frontend
{
    partial class gestionarTransportista
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
            this.dtgvGestionarTransportistas = new System.Windows.Forms.DataGridView();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnNuevoTransportista = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNomTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridContrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNumeroIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOpciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarTransportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvGestionarTransportistas
            // 
            this.dtgvGestionarTransportistas.AllowUserToAddRows = false;
            this.dtgvGestionarTransportistas.AllowUserToDeleteRows = false;
            this.dtgvGestionarTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarTransportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridRut,
            this.dataGridNomTransportista,
            this.dataGridIdTransportista,
            this.dataGridApellidoPaterno,
            this.dataGridApellidoMaterno,
            this.dataGridCorreo,
            this.dataGridContrasena,
            this.dataGridNumeroIdentificador,
            this.dataGridDireccion,
            this.dataGridCodigoPostal,
            this.dataGridTelefono,
            this.dataGridOpciones});
            this.dtgvGestionarTransportistas.Location = new System.Drawing.Point(83, 142);
            this.dtgvGestionarTransportistas.Name = "dtgvGestionarTransportistas";
            this.dtgvGestionarTransportistas.ReadOnly = true;
            this.dtgvGestionarTransportistas.Size = new System.Drawing.Size(638, 259);
            this.dtgvGestionarTransportistas.TabIndex = 17;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(445, 100);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(276, 20);
            this.txtRut.TabIndex = 15;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 20);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnNuevoTransportista
            // 
            this.btnNuevoTransportista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTransportista.Location = new System.Drawing.Point(492, 420);
            this.btnNuevoTransportista.Name = "btnNuevoTransportista";
            this.btnNuevoTransportista.Size = new System.Drawing.Size(229, 34);
            this.btnNuevoTransportista.TabIndex = 13;
            this.btnNuevoTransportista.Text = "Nuevo Transportista";
            this.btnNuevoTransportista.UseVisualStyleBackColor = true;
            this.btnNuevoTransportista.Click += new System.EventHandler(this.btnNuevoTransportista_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(83, 420);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(177, 34);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestionar Transportistas";
            // 
            // dataGridRut
            // 
            this.dataGridRut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridRut.DataPropertyName = "rut";
            this.dataGridRut.HeaderText = "Rut";
            this.dataGridRut.Name = "dataGridRut";
            this.dataGridRut.ReadOnly = true;
            // 
            // dataGridNomTransportista
            // 
            this.dataGridNomTransportista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridNomTransportista.DataPropertyName = "nombre";
            this.dataGridNomTransportista.HeaderText = "Nombre Transportista";
            this.dataGridNomTransportista.Name = "dataGridNomTransportista";
            this.dataGridNomTransportista.ReadOnly = true;
            // 
            // dataGridIdTransportista
            // 
            this.dataGridIdTransportista.DataPropertyName = "idTransportista";
            this.dataGridIdTransportista.HeaderText = "idTransportista";
            this.dataGridIdTransportista.Name = "dataGridIdTransportista";
            this.dataGridIdTransportista.ReadOnly = true;
            this.dataGridIdTransportista.Visible = false;
            // 
            // dataGridApellidoPaterno
            // 
            this.dataGridApellidoPaterno.DataPropertyName = "apellidoPaterno";
            this.dataGridApellidoPaterno.HeaderText = "ApellidoPaterno";
            this.dataGridApellidoPaterno.Name = "dataGridApellidoPaterno";
            this.dataGridApellidoPaterno.ReadOnly = true;
            this.dataGridApellidoPaterno.Visible = false;
            // 
            // dataGridApellidoMaterno
            // 
            this.dataGridApellidoMaterno.DataPropertyName = "apellidoMaterno";
            this.dataGridApellidoMaterno.HeaderText = "ApellidoMaterno";
            this.dataGridApellidoMaterno.Name = "dataGridApellidoMaterno";
            this.dataGridApellidoMaterno.ReadOnly = true;
            this.dataGridApellidoMaterno.Visible = false;
            // 
            // dataGridCorreo
            // 
            this.dataGridCorreo.DataPropertyName = "correo";
            this.dataGridCorreo.HeaderText = "Correo";
            this.dataGridCorreo.Name = "dataGridCorreo";
            this.dataGridCorreo.ReadOnly = true;
            this.dataGridCorreo.Visible = false;
            // 
            // dataGridContrasena
            // 
            this.dataGridContrasena.DataPropertyName = "contrasena";
            this.dataGridContrasena.HeaderText = "Contrasena";
            this.dataGridContrasena.Name = "dataGridContrasena";
            this.dataGridContrasena.ReadOnly = true;
            this.dataGridContrasena.Visible = false;
            // 
            // dataGridNumeroIdentificador
            // 
            this.dataGridNumeroIdentificador.DataPropertyName = "numeroIdentificador";
            this.dataGridNumeroIdentificador.HeaderText = "NumeroIdentificador";
            this.dataGridNumeroIdentificador.Name = "dataGridNumeroIdentificador";
            this.dataGridNumeroIdentificador.ReadOnly = true;
            this.dataGridNumeroIdentificador.Visible = false;
            // 
            // dataGridDireccion
            // 
            this.dataGridDireccion.DataPropertyName = "direccion";
            this.dataGridDireccion.HeaderText = "Direccion";
            this.dataGridDireccion.Name = "dataGridDireccion";
            this.dataGridDireccion.ReadOnly = true;
            this.dataGridDireccion.Visible = false;
            // 
            // dataGridCodigoPostal
            // 
            this.dataGridCodigoPostal.DataPropertyName = "codigoPostal";
            this.dataGridCodigoPostal.HeaderText = "CodigoPostal";
            this.dataGridCodigoPostal.Name = "dataGridCodigoPostal";
            this.dataGridCodigoPostal.ReadOnly = true;
            this.dataGridCodigoPostal.Visible = false;
            // 
            // dataGridTelefono
            // 
            this.dataGridTelefono.DataPropertyName = "telefono";
            this.dataGridTelefono.HeaderText = "Telefono";
            this.dataGridTelefono.Name = "dataGridTelefono";
            this.dataGridTelefono.ReadOnly = true;
            this.dataGridTelefono.Visible = false;
            // 
            // dataGridOpciones
            // 
            this.dataGridOpciones.HeaderText = "Opciones";
            this.dataGridOpciones.Name = "dataGridOpciones";
            this.dataGridOpciones.ReadOnly = true;
            this.dataGridOpciones.Text = "Editar";
            this.dataGridOpciones.UseColumnTextForButtonValue = true;
            // 
            // gestionarTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.dtgvGestionarTransportistas);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnNuevoTransportista);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gestionarTransportista";
            this.Text = "gestionarTransportista";
            this.Load += new System.EventHandler(this.gestionarTransportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarTransportistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGestionarTransportistas;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnNuevoTransportista;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNomTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridContrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNumeroIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOpciones;
    }
}