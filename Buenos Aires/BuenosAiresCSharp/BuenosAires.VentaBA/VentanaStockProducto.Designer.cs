
namespace BuenosAires.VentaBA
{
    partial class VentanaStockProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNroFac = new System.Windows.Forms.TextBox();
            this.TxtIdProd = new System.Windows.Forms.TextBox();
            this.TxtIdStock = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.DgvStockProducto = new System.Windows.Forms.DataGridView();
            this.BtnTestXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(201, 169);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(166, 41);
            this.BtnNuevo.TabIndex = 21;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(373, 169);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(166, 41);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(310, 23);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(166, 41);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "N° de factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID de producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // TxtNroFac
            // 
            this.TxtNroFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroFac.Location = new System.Drawing.Point(189, 117);
            this.TxtNroFac.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtNroFac.Name = "TxtNroFac";
            this.TxtNroFac.Size = new System.Drawing.Size(112, 32);
            this.TxtNroFac.TabIndex = 17;
            // 
            // TxtIdProd
            // 
            this.TxtIdProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdProd.Location = new System.Drawing.Point(189, 71);
            this.TxtIdProd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtIdProd.Name = "TxtIdProd";
            this.TxtIdProd.Size = new System.Drawing.Size(112, 32);
            this.TxtIdProd.TabIndex = 16;
            // 
            // TxtIdStock
            // 
            this.TxtIdStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdStock.Location = new System.Drawing.Point(189, 24);
            this.TxtIdStock.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtIdStock.Name = "TxtIdStock";
            this.TxtIdStock.ReadOnly = true;
            this.TxtIdStock.Size = new System.Drawing.Size(112, 32);
            this.TxtIdStock.TabIndex = 14;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(28, 169);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(166, 40);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(545, 169);
            this.BtnCargar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(166, 41);
            this.BtnCargar.TabIndex = 26;
            this.BtnCargar.Text = "Cargar productos";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // DgvStockProducto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStockProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStockProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStockProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvStockProducto.Location = new System.Drawing.Point(28, 231);
            this.DgvStockProducto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DgvStockProducto.Name = "DgvStockProducto";
            this.DgvStockProducto.RowHeadersWidth = 51;
            this.DgvStockProducto.RowTemplate.Height = 24;
            this.DgvStockProducto.Size = new System.Drawing.Size(1233, 472);
            this.DgvStockProducto.TabIndex = 27;
            this.DgvStockProducto.SelectionChanged += new System.EventHandler(this.DgvStockProducto_SelectionChanged);
            // 
            // BtnTestXML
            // 
            this.BtnTestXML.Location = new System.Drawing.Point(717, 169);
            this.BtnTestXML.Name = "BtnTestXML";
            this.BtnTestXML.Size = new System.Drawing.Size(166, 41);
            this.BtnTestXML.TabIndex = 28;
            this.BtnTestXML.Text = "Test XML";
            this.BtnTestXML.UseVisualStyleBackColor = true;
            this.BtnTestXML.Click += new System.EventHandler(this.BtnTestXML_Click);
            // 
            // VentanaStockProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 732);
            this.Controls.Add(this.BtnTestXML);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNroFac);
            this.Controls.Add(this.TxtIdProd);
            this.Controls.Add(this.TxtIdStock);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.DgvStockProducto);
            this.Name = "VentanaStockProducto";
            this.Text = "Ventana de Stock en Bodega";
            this.Load += new System.EventHandler(this.VentanaStockProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNroFac;
        private System.Windows.Forms.TextBox TxtIdProd;
        private System.Windows.Forms.TextBox TxtIdStock;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.DataGridView DgvStockProducto;
        private System.Windows.Forms.Button BtnTestXML;
    }
}