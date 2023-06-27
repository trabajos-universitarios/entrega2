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
using Newtonsoft.Json;

namespace BuenosAires.VentaBA
{
    public partial class VentanaLogin : Form
    {
        public VentanaStockProducto ventanaStockProducto = new VentanaStockProducto();
        public VentanaAnwo ventanaAnwo = new VentanaAnwo();

        public VentanaLogin()
        {
            InitializeComponent();
            this.AcceptButton = BtnIngresar;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtCuenta.Text.Trim() == "")
            {
                Util.MostrarMensajeError("Debe ingresar una cuenta");
                return;
            }
            if (TxtPassword.Text.Trim() == "")
            {
                Util.MostrarMensajeError("Debe ingresar una password");
                return;
            }
            var ws = new ServicioStockProductoClient();
            ws.InnerChannel.OperationTimeout = new TimeSpan(1, 0, 0);
            Respuesta respuesta = ws.VerificarPassword(TxtCuenta.Text, TxtPassword.Text);
            if (respuesta.Mensaje != "") Util.MostrarMensaje(respuesta.Mensaje, respuesta.HayErrores);
            var autenticado = respuesta.JsonVerificarPassword.Contains("\"autenticado\": true");
            if (autenticado)
            {
                if (ventanaAnwo.IsDisposed) ventanaAnwo = new VentanaAnwo();
                ventanaAnwo.Show();
            }
            else
            {
                Util.MostrarMensajeInformativo("La cuenta o la contraseña son incorrectos");
            }
        }

        private void BtnVerEjemplo_Click(object sender, EventArgs e)
        {
            if (ventanaStockProducto.IsDisposed) ventanaStockProducto = new VentanaStockProducto();
            ventanaStockProducto.Show();
        }
    }
}
