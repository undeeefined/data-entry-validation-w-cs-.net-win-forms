
using System;
using System.Windows.Forms;

namespace Validacion_datos_U2
{
    partial class Form1
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
            this.lblLetras = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras.ForeColor = System.Drawing.Color.Green;
            this.lblLetras.Location = new System.Drawing.Point(80, 82);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(114, 24);
            this.lblLetras.TabIndex = 0;
            this.lblLetras.Text = "Solo Letras";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Green;
            this.lblEmail.Location = new System.Drawing.Point(80, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(186, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.ForeColor = System.Drawing.Color.Green;
            this.lblNumeros.Location = new System.Drawing.Point(80, 133);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(143, 24);
            this.lblNumeros.TabIndex = 4;
            this.lblNumeros.Text = "Solo Numeros";
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(288, 82);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(100, 20);
            this.txtLetras.TabIndex = 5;
            this.txtLetras.TextChanged += new System.EventHandler(this.txtLetras_TextChanged);
            this.txtLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(288, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(288, 133);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtNumeros.TabIndex = 7;
            this.txtNumeros.TextChanged += new System.EventHandler(this.txtLetras_TextChanged);
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.Red;
            this.btnValidar.Location = new System.Drawing.Point(191, 237);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(84, 38);
            this.btnValidar.TabIndex = 8;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(304, 238);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 38);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLetras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnSalir;
    }
}

