
namespace feriavirtual_frontend
{
    partial class menuAdministrador
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnGestionarVentas = new System.Windows.Forms.Button();
            this.btnGestionarInformes = new System.Windows.Forms.Button();
            this.btnGestionarSubastas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnCerrarSesion.Location = new System.Drawing.Point(290, 364);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(198, 39);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(290, 138);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(198, 41);
            this.btnGestionarUsuarios.TabIndex = 1;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnGestionarVentas
            // 
            this.btnGestionarVentas.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnGestionarVentas.Location = new System.Drawing.Point(290, 195);
            this.btnGestionarVentas.Name = "btnGestionarVentas";
            this.btnGestionarVentas.Size = new System.Drawing.Size(198, 36);
            this.btnGestionarVentas.TabIndex = 2;
            this.btnGestionarVentas.Text = "Gestionar Ventas";
            this.btnGestionarVentas.UseVisualStyleBackColor = true;
            // 
            // btnGestionarInformes
            // 
            this.btnGestionarInformes.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnGestionarInformes.Location = new System.Drawing.Point(290, 253);
            this.btnGestionarInformes.Name = "btnGestionarInformes";
            this.btnGestionarInformes.Size = new System.Drawing.Size(198, 36);
            this.btnGestionarInformes.TabIndex = 3;
            this.btnGestionarInformes.Text = "Gestionar Informes";
            this.btnGestionarInformes.UseVisualStyleBackColor = true;
            // 
            // btnGestionarSubastas
            // 
            this.btnGestionarSubastas.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnGestionarSubastas.Location = new System.Drawing.Point(290, 307);
            this.btnGestionarSubastas.Name = "btnGestionarSubastas";
            this.btnGestionarSubastas.Size = new System.Drawing.Size(198, 37);
            this.btnGestionarSubastas.TabIndex = 4;
            this.btnGestionarSubastas.Text = "Gestionar Subastas";
            this.btnGestionarSubastas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Panel Administrador";
            // 
            // menuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestionarSubastas);
            this.Controls.Add(this.btnGestionarInformes);
            this.Controls.Add(this.btnGestionarVentas);
            this.Controls.Add(this.btnGestionarUsuarios);
            this.Controls.Add(this.btnCerrarSesion);
            this.Name = "menuAdministrador";
            this.Text = "Bienvenido Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnGestionarVentas;
        private System.Windows.Forms.Button btnGestionarInformes;
        private System.Windows.Forms.Button btnGestionarSubastas;
        private System.Windows.Forms.Label label1;
    }
}