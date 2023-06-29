using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuenosAires.VentaBA.ServicioStockProducto;

namespace BuenosAires.VentaBA
{
    public partial class VentanaAnwo : Form
    {
        public VentanaAnwo()
        {
            InitializeComponent();
            DgvAnwoProducto.AutoGenerateColumns = false;
            DgvAnwoProducto.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "nroserieanwo", DataPropertyName = "nroserieanwo", HeaderText = "ID de producto Anwo" },
                new DataGridViewTextBoxColumn() { Name = "nomprodanwo", DataPropertyName = "nomprodanwo", HeaderText = "Nombre de producto" },
                new DataGridViewTextBoxColumn() { Name = "precioanwo", DataPropertyName = "precioanwo", HeaderText = "Precio" },
                new DataGridViewTextBoxColumn() { Name = "reservadoba", DataPropertyName = "reservadoba", HeaderText = "Reservado" },
            });
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Opciones";
            buttonColumn.Text = "Reservar";
            buttonColumn.UseColumnTextForButtonValue = true;
            DgvAnwoProducto.Columns.Add(buttonColumn);
            DgvAnwoProducto.CellClick += DgvAnwoProducto_CellClick;

            DgvAnwoProducto.ReadOnly = true;
            DgvAnwoProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvAnwoProducto.MultiSelect = false;
            RefrescarDataGridView();

            StartPosition = FormStartPosition.CenterScreen;
        }
        private void DgvAnwoProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DgvAnwoProducto.Rows[e.RowIndex];
                DataGridViewColumn column = DgvAnwoProducto.Columns[e.ColumnIndex];
                var nroserieanwo = row.Cells["nroserieanwo"].Value.ToString();

                var ws = new ServicioStockProductoClient();
                ws.InnerChannel.OperationTimeout = new TimeSpan(1, 0, 0);
                Respuesta respuesta = ws.Reservar(nroserieanwo);
                if (respuesta.Mensaje != "") Util.MostrarMensaje(respuesta.Mensaje, respuesta.HayErrores);
                RefrescarDataGridView();
            }

        }
        public void RefrescarDataGridView()
        {
            var ws = new ServicioStockProductoClient();
            ws.InnerChannel.OperationTimeout = new TimeSpan(1, 0, 0);
            Respuesta respuesta = ws.LeerTodosAnwoListaProducto();

            if (respuesta.Mensaje != "") Util.MostrarMensaje(respuesta.Mensaje, respuesta.HayErrores);
            var lista = Util.DeserializarXML<List<AnwoListaProducto>>(respuesta.XmlListaAnwoListaProducto);

            DgvAnwoProducto.DataSource = lista;
            DgvAnwoProducto.Refresh();
            DgvAnwoProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

    }

        
}

