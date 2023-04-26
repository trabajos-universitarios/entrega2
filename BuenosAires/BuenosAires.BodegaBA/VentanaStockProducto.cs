using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuenosAires.BusinessLayer;
using BuenosAires.Model;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaStockProducto : Form
    {
        public VentanaStockProducto()
        {
            InitializeComponent();
            DgvProducto.AutoGenerateColumns = false;
            DgvProducto.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "idprod", DataPropertyName = "idprod", HeaderText = "ID" },
                new DataGridViewTextBoxColumn() { Name = "nomprod", DataPropertyName = "nomprod", HeaderText = "Nombre" },
                new DataGridViewTextBoxColumn() { Name = "descprod", DataPropertyName = "descprod", HeaderText = "Descripción" },
                new DataGridViewTextBoxColumn() { Name = "precio", DataPropertyName = "precio", HeaderText = "Precio" },
                new DataGridViewTextBoxColumn() { Name = "imagen", DataPropertyName = "imagen", HeaderText = "Imagen" },
                new DataGridViewTextBoxColumn() { Name = "cantidad", DataPropertyName = "cantidad", HeaderText = "Cantidad" },
            });
            DgvProducto.ReadOnly = true;
            DgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProducto.MultiSelect = false;
            StartPosition = FormStartPosition.CenterScreen;
        }



        public void RefrescarDataGridView()
        {
            var bc = new BcProducto();
            bc.LeerTodos();
            if (bc.Mensaje != "") Util.MostrarMensaje(bc.Mensaje, bc.HayErrores);
            DgvProducto.DataSource = bc.Lista;
            DgvProducto.Refresh();
            DgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void VentanaStockProducto_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            RefrescarDataGridView();
        }

        private void DgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
