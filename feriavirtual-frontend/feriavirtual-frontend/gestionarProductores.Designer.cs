
namespace feriavirtual_frontend
{
    partial class gestionarProductores
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtgvGestionarProductor = new System.Windows.Forms.DataGridView();
            this.btnNuevoProductor = new System.Windows.Forms.Button();
            this.dataGridContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNomProductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNumeroIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridContrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOpcion1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridOpcion2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarProductor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(81, 397);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 32);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestionar Productores";
            // 
            // dtgvGestionarProductor
            // 
            this.dtgvGestionarProductor.AllowUserToAddRows = false;
            this.dtgvGestionarProductor.AllowUserToDeleteRows = false;
            this.dtgvGestionarProductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarProductor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridContrato,
            this.dataGridIdPais,
            this.dataGridIdTipoUsuario,
            this.dataGridNomProductor,
            this.dataGridIdUsuario,
            this.dataGridRut,
            this.dataGridNumeroIdentificador,
            this.dataGridDireccion,
            this.dataGridCodigoPostal,
            this.dataGridTelefono,
            this.dataGridApellidoPaterno,
            this.dataGridApellidoMaterno,
            this.dataGridCorreo,
            this.dataGridContrasena,
            this.dataGridOpcion1,
            this.dataGridOpcion2});
            this.dtgvGestionarProductor.Location = new System.Drawing.Point(81, 147);
            this.dtgvGestionarProductor.Name = "dtgvGestionarProductor";
            this.dtgvGestionarProductor.ReadOnly = true;
            this.dtgvGestionarProductor.Size = new System.Drawing.Size(639, 228);
            this.dtgvGestionarProductor.TabIndex = 3;
            this.dtgvGestionarProductor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGestionarProductor_CellContentClick);
            // 
            // btnNuevoProductor
            // 
            this.btnNuevoProductor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProductor.Location = new System.Drawing.Point(527, 397);
            this.btnNuevoProductor.Name = "btnNuevoProductor";
            this.btnNuevoProductor.Size = new System.Drawing.Size(193, 32);
            this.btnNuevoProductor.TabIndex = 4;
            this.btnNuevoProductor.Text = "Nuevo Productor";
            this.btnNuevoProductor.UseVisualStyleBackColor = true;
            this.btnNuevoProductor.Click += new System.EventHandler(this.btnNuevoProductor_Click);
            // 
            // dataGridContrato
            // 
            this.dataGridContrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridContrato.DataPropertyName = "idContrato";
            this.dataGridContrato.HeaderText = "Contrato";
            this.dataGridContrato.Name = "dataGridContrato";
            this.dataGridContrato.ReadOnly = true;
            // 
            // dataGridIdPais
            // 
            this.dataGridIdPais.DataPropertyName = "idPais";
            this.dataGridIdPais.HeaderText = "idPais";
            this.dataGridIdPais.Name = "dataGridIdPais";
            this.dataGridIdPais.ReadOnly = true;
            this.dataGridIdPais.Visible = false;
            // 
            // dataGridIdTipoUsuario
            // 
            this.dataGridIdTipoUsuario.DataPropertyName = "idTipoUsuario";
            this.dataGridIdTipoUsuario.HeaderText = "IdTipoUsuario";
            this.dataGridIdTipoUsuario.Name = "dataGridIdTipoUsuario";
            this.dataGridIdTipoUsuario.ReadOnly = true;
            this.dataGridIdTipoUsuario.Visible = false;
            // 
            // dataGridNomProductor
            // 
            this.dataGridNomProductor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridNomProductor.DataPropertyName = "nombre";
            this.dataGridNomProductor.HeaderText = "Nombre Productor";
            this.dataGridNomProductor.Name = "dataGridNomProductor";
            this.dataGridNomProductor.ReadOnly = true;
            // 
            // dataGridIdUsuario
            // 
            this.dataGridIdUsuario.DataPropertyName = "idUsuario";
            this.dataGridIdUsuario.HeaderText = "IdUsuario";
            this.dataGridIdUsuario.Name = "dataGridIdUsuario";
            this.dataGridIdUsuario.ReadOnly = true;
            this.dataGridIdUsuario.Visible = false;
            // 
            // dataGridRut
            // 
            this.dataGridRut.DataPropertyName = "rut";
            this.dataGridRut.HeaderText = "Rut";
            this.dataGridRut.Name = "dataGridRut";
            this.dataGridRut.ReadOnly = true;
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
            // dataGridOpcion1
            // 
            this.dataGridOpcion1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridOpcion1.HeaderText = "Opcion1";
            this.dataGridOpcion1.Name = "dataGridOpcion1";
            this.dataGridOpcion1.ReadOnly = true;
            this.dataGridOpcion1.Text = "Editar";
            this.dataGridOpcion1.UseColumnTextForButtonValue = true;
            this.dataGridOpcion1.Width = 53;
            // 
            // dataGridOpcion2
            // 
            this.dataGridOpcion2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridOpcion2.HeaderText = "Opcion2";
            this.dataGridOpcion2.Name = "dataGridOpcion2";
            this.dataGridOpcion2.ReadOnly = true;
            this.dataGridOpcion2.Text = "Eliminar";
            this.dataGridOpcion2.UseColumnTextForButtonValue = true;
            this.dataGridOpcion2.Width = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rut:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(481, 100);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(239, 20);
            this.txtRut.TabIndex = 8;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // gestionarProductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNuevoProductor);
            this.Controls.Add(this.dtgvGestionarProductor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Name = "gestionarProductores";
            this.Text = "gestionarProductores";
            this.Load += new System.EventHandler(this.gestionarProductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionarProductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtgvGestionarProductor;
        private System.Windows.Forms.Button btnNuevoProductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdTipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNomProductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNumeroIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridContrasena;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOpcion1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOpcion2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRut;
    }
}