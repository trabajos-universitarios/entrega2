
namespace BuenosAires.VentaBA
{
    partial class VentanaAnwo
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
            this.DgvAnwoProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnwoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAnwoProducto
            // 
            this.DgvAnwoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAnwoProducto.Location = new System.Drawing.Point(25, 27);
            this.DgvAnwoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvAnwoProducto.Name = "DgvAnwoProducto";
            this.DgvAnwoProducto.RowHeadersWidth = 62;
            this.DgvAnwoProducto.RowTemplate.Height = 24;
            this.DgvAnwoProducto.Size = new System.Drawing.Size(866, 463);
            this.DgvAnwoProducto.TabIndex = 32;
            // 
            // VentanaAnwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 513);
            this.Controls.Add(this.DgvAnwoProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaAnwo";
            this.Text = "VentanaAnwo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnwoProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAnwoProducto;
    }
}