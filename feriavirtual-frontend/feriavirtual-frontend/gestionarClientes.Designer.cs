
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.dtgvGestionarClientes = new System.Windows.Forms.DataGridView();
            this.dataGridRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridContrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNumeroIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOptions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(294, 138);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(198, 20);
            this.txtRut.TabIndex = 6;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCliente.FormattingEnabled = true;
            this.cbxTipoCliente.Items.AddRange(new object[] {
            "Cliente Externo",
            "Cliente Local",
            "Cliente Interno"});
            this.cbxTipoCliente.Location = new System.Drawing.Point(517, 134);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(202, 24);
            this.cbxTipoCliente.TabIndex = 7;
            this.cbxTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cbxTipoCliente_SelectedIndexChanged);
            // 
            // dtgvGestionarClientes
            // 
            this.dtgvGestionarClientes.AllowUserToAddRows = false;
            this.dtgvGestionarClientes.AllowUserToDeleteRows = false;
            this.dtgvGestionarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridRut,
            this.dataGridNomCliente,
            this.dataGridIdTipoCliente,
            this.dataGridIdPais,
            this.dataGridIdUsuario,
            this.dataGridApellidoPaterno,
            this.dataGridApellidoMaterno,
            this.dataGridCorreo,
            this.dataGridContrasena,
            this.dataGridNumeroIdentificador,
            this.dataGridDireccion,
            this.dataGridCodigoPostal,
            this.dataGridTelefono,
            this.dataGridOptions});
            this.dtgvGestionarClientes.Location = new System.Drawing.Point(81, 180);
            this.dtgvGestionarClientes.Name = "dtgvGestionarClientes";
            this.dtgvGestionarClientes.ReadOnly = true;
            this.dtgvGestionarClientes.Size = new System.Drawing.Size(638, 259);
            this.dtgvGestionarClientes.TabIndex = 8;
            // 
            // dataGridRut
            // 
            this.dataGridRut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridRut.DataPropertyName = "rut";
            this.dataGridRut.HeaderText = "Rut";
            this.dataGridRut.Name = "dataGridRut";
            this.dataGridRut.ReadOnly = true;
            this.dataGridRut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridNomCliente
            // 
            this.dataGridNomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridNomCliente.DataPropertyName = "nombre";
            this.dataGridNomCliente.HeaderText = "Nombre Cliente";
            this.dataGridNomCliente.Name = "dataGridNomCliente";
            this.dataGridNomCliente.ReadOnly = true;
            this.dataGridNomCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridIdTipoCliente
            // 
            this.dataGridIdTipoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridIdTipoCliente.DataPropertyName = "idTipoUsuario";
            this.dataGridIdTipoCliente.HeaderText = "Id Tipo Cliente";
            this.dataGridIdTipoCliente.Name = "dataGridIdTipoCliente";
            this.dataGridIdTipoCliente.ReadOnly = true;
            this.dataGridIdTipoCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridIdPais
            // 
            this.dataGridIdPais.DataPropertyName = "IdPais";
            this.dataGridIdPais.HeaderText = "Id Pais";
            this.dataGridIdPais.Name = "dataGridIdPais";
            this.dataGridIdPais.ReadOnly = true;
            this.dataGridIdPais.Visible = false;
            // 
            // dataGridIdUsuario
            // 
            this.dataGridIdUsuario.DataPropertyName = "idUsuario";
            this.dataGridIdUsuario.HeaderText = "Id Usuario";
            this.dataGridIdUsuario.Name = "dataGridIdUsuario";
            this.dataGridIdUsuario.ReadOnly = true;
            this.dataGridIdUsuario.Visible = false;
            // 
            // dataGridApellidoPaterno
            // 
            this.dataGridApellidoPaterno.DataPropertyName = "apellidoPaterno";
            this.dataGridApellidoPaterno.HeaderText = "Apellido Paterno";
            this.dataGridApellidoPaterno.Name = "dataGridApellidoPaterno";
            this.dataGridApellidoPaterno.ReadOnly = true;
            this.dataGridApellidoPaterno.Visible = false;
            // 
            // dataGridApellidoMaterno
            // 
            this.dataGridApellidoMaterno.DataPropertyName = "apellidoMaterno";
            this.dataGridApellidoMaterno.HeaderText = "Apellido Materno";
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
            this.dataGridNumeroIdentificador.HeaderText = "Numero Identificador";
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
            this.dataGridCodigoPostal.HeaderText = "Codigo Postal";
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
            // dataGridOptions
            // 
            this.dataGridOptions.HeaderText = "Opciones";
            this.dataGridOptions.Name = "dataGridOptions";
            this.dataGridOptions.ReadOnly = true;
            this.dataGridOptions.Text = "Editar";
            this.dataGridOptions.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Cliente";
            // 
            // gestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvGestionarClientes);
            this.Controls.Add(this.cbxTipoCliente);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gestionarClientes";
            this.Text = "gestionarClientes";
            this.Load += new System.EventHandler(this.gestionarClientes_Load);
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.DataGridView dtgvGestionarClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridContrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridNumeroIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridOptions;
    }
}