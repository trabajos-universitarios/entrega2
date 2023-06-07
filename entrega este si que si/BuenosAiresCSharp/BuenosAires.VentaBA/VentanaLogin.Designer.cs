
namespace BuenosAires.VentaBA
{
    partial class VentanaLogin
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
            this.TxtCuenta = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnVerEjemplo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCuenta
            // 
            this.TxtCuenta.Location = new System.Drawing.Point(184, 115);
            this.TxtCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCuenta.Name = "TxtCuenta";
            this.TxtCuenta.Size = new System.Drawing.Size(132, 22);
            this.TxtCuenta.TabIndex = 0;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(184, 160);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(132, 22);
            this.TxtPassword.TabIndex = 1;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(106, 213);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(191, 28);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // BtnVerEjemplo
            // 
            this.BtnVerEjemplo.Location = new System.Drawing.Point(106, 249);
            this.BtnVerEjemplo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVerEjemplo.Name = "BtnVerEjemplo";
            this.BtnVerEjemplo.Size = new System.Drawing.Size(192, 28);
            this.BtnVerEjemplo.TabIndex = 6;
            this.BtnVerEjemplo.Text = "Ver ventana de ejemplo";
            this.BtnVerEjemplo.UseVisualStyleBackColor = true;
            this.BtnVerEjemplo.Click += new System.EventHandler(this.BtnVerEjemplo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingresar al Sistema de Bodega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buenos Aires";
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVerEjemplo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtCuenta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaLogin";
            this.Text = "Iniciar sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCuenta;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnVerEjemplo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}