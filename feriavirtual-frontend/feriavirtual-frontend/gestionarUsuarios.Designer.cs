
namespace feriavirtual_frontend
{
    partial class gestionarUsuarios
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
            this.btnGestionarProductores = new System.Windows.Forms.Button();
            this.btnGestionarClientes = new System.Windows.Forms.Button();
            this.btnGestionarTransportistas = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Usuarios";
            // 
            // btnGestionarProductores
            // 
            this.btnGestionarProductores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarProductores.Location = new System.Drawing.Point(304, 138);
            this.btnGestionarProductores.Name = "btnGestionarProductores";
            this.btnGestionarProductores.Size = new System.Drawing.Size(211, 43);
            this.btnGestionarProductores.TabIndex = 1;
            this.btnGestionarProductores.Text = "Gestionar Productores";
            this.btnGestionarProductores.UseVisualStyleBackColor = true;
            this.btnGestionarProductores.Click += new System.EventHandler(this.btnGestionarProductores_Click);
            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarClientes.Location = new System.Drawing.Point(304, 187);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Size = new System.Drawing.Size(211, 40);
            this.btnGestionarClientes.TabIndex = 2;
            this.btnGestionarClientes.Text = "Gestionar Clientes";
            this.btnGestionarClientes.UseVisualStyleBackColor = true;
            this.btnGestionarClientes.Click += new System.EventHandler(this.btnGestionarClientes_Click);
            // 
            // btnGestionarTransportistas
            // 
            this.btnGestionarTransportistas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarTransportistas.Location = new System.Drawing.Point(304, 233);
            this.btnGestionarTransportistas.Name = "btnGestionarTransportistas";
            this.btnGestionarTransportistas.Size = new System.Drawing.Size(211, 39);
            this.btnGestionarTransportistas.TabIndex = 3;
            this.btnGestionarTransportistas.Text = "Gestionar Transportistas";
            this.btnGestionarTransportistas.UseVisualStyleBackColor = true;
            this.btnGestionarTransportistas.Click += new System.EventHandler(this.btnGestionarTransportistas_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(304, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGestionarTransportistas);
            this.Controls.Add(this.btnGestionarClientes);
            this.Controls.Add(this.btnGestionarProductores);
            this.Controls.Add(this.label1);
            this.Name = "gestionarUsuarios";
            this.Text = "gestionarUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionarProductores;
        private System.Windows.Forms.Button btnGestionarClientes;
        private System.Windows.Forms.Button btnGestionarTransportistas;
        private System.Windows.Forms.Button button4;
    }
}