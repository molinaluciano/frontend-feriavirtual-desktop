
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Usuarios";
            // 
            // btnGestionarProductores
            // 
            this.btnGestionarProductores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarProductores.AutoSize = true;
            this.btnGestionarProductores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(145)))));
            this.btnGestionarProductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarProductores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarProductores.ForeColor = System.Drawing.Color.Silver;
            this.btnGestionarProductores.Location = new System.Drawing.Point(339, 276);
            this.btnGestionarProductores.Name = "btnGestionarProductores";
            this.btnGestionarProductores.Size = new System.Drawing.Size(323, 58);
            this.btnGestionarProductores.TabIndex = 1;
            this.btnGestionarProductores.Text = "Gestionar Productores";
            this.btnGestionarProductores.UseVisualStyleBackColor = false;
            this.btnGestionarProductores.Click += new System.EventHandler(this.btnGestionarProductores_Click);
            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarClientes.AutoSize = true;
            this.btnGestionarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(145)))));
            this.btnGestionarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnGestionarClientes.Location = new System.Drawing.Point(339, 187);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Size = new System.Drawing.Size(323, 58);
            this.btnGestionarClientes.TabIndex = 2;
            this.btnGestionarClientes.Text = "Gestionar Clientes";
            this.btnGestionarClientes.UseVisualStyleBackColor = false;
            this.btnGestionarClientes.Click += new System.EventHandler(this.btnGestionarClientes_Click);
            // 
            // btnGestionarTransportistas
            // 
            this.btnGestionarTransportistas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarTransportistas.AutoSize = true;
            this.btnGestionarTransportistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(145)))));
            this.btnGestionarTransportistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarTransportistas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarTransportistas.ForeColor = System.Drawing.Color.Silver;
            this.btnGestionarTransportistas.Location = new System.Drawing.Point(339, 362);
            this.btnGestionarTransportistas.Name = "btnGestionarTransportistas";
            this.btnGestionarTransportistas.Size = new System.Drawing.Size(323, 58);
            this.btnGestionarTransportistas.TabIndex = 3;
            this.btnGestionarTransportistas.Text = "Gestionar Transportistas";
            this.btnGestionarTransportistas.UseVisualStyleBackColor = false;
            this.btnGestionarTransportistas.Click += new System.EventHandler(this.btnGestionarTransportistas_Click);
            // 
            // gestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 542);
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
    }
}