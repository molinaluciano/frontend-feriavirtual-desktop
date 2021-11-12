
namespace feriavirtual_frontend
{
    partial class ingresarSaldos
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
            this.cbxFruta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarSaldo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Saldos";
            // 
            // cbxFruta
            // 
            this.cbxFruta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFruta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFruta.FormattingEnabled = true;
            this.cbxFruta.Location = new System.Drawing.Point(221, 141);
            this.cbxFruta.MinimumSize = new System.Drawing.Size(450, 0);
            this.cbxFruta.Name = "cbxFruta";
            this.cbxFruta.Size = new System.Drawing.Size(563, 25);
            this.cbxFruta.TabIndex = 1;
            this.cbxFruta.Text = "Fruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kg:";
            // 
            // cbxCalidad
            // 
            this.cbxCalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCalidad.FormattingEnabled = true;
            this.cbxCalidad.Location = new System.Drawing.Point(312, 199);
            this.cbxCalidad.Name = "cbxCalidad";
            this.cbxCalidad.Size = new System.Drawing.Size(161, 25);
            this.cbxCalidad.TabIndex = 4;
            this.cbxCalidad.Text = "Calidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Location = new System.Drawing.Point(492, 202);
            this.txtPrecio.MinimumSize = new System.Drawing.Size(170, 20);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(292, 20);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.Text = "$";
            // 
            // txtKg
            // 
            this.txtKg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKg.Location = new System.Drawing.Point(221, 200);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(42, 23);
            this.txtKg.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción:";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(170, 268);
            this.textBox1.MinimumSize = new System.Drawing.Size(500, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(614, 50);
            this.textBox1.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(170, 384);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(184, 49);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarSaldo
            // 
            this.btnAgregarSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSaldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSaldo.Location = new System.Drawing.Point(591, 384);
            this.btnAgregarSaldo.Name = "btnAgregarSaldo";
            this.btnAgregarSaldo.Size = new System.Drawing.Size(193, 49);
            this.btnAgregarSaldo.TabIndex = 11;
            this.btnAgregarSaldo.Text = "Agregar Saldo";
            this.btnAgregarSaldo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fruta:";
            // 
            // ingresarSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarSaldo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCalidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFruta);
            this.Controls.Add(this.label1);
            this.Name = "ingresarSaldos";
            this.Text = "ingresarSaldos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFruta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarSaldo;
        private System.Windows.Forms.Label label5;
    }
}