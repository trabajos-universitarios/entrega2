using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenosAires.Model;
using BuenosAires.DataLayer;

namespace BuenosAires.BusinessLayer
{
    class BcStockProducto
    {
        public string Accion = "";
        public string Mensaje = "";
        public bool HayErrores = false;
        public StockProducto StockProducto = null;
        public List<StockProducto> Lista = null;

        public BcStockProducto()
        {
            Inicializar("");
        }

        private void Inicializar(string accion)
        {
            this.Accion = accion;
            this.Mensaje = "";
            this.HayErrores = false;
            this.StockProducto = null;
            this.Lista = null;
        }
        public int ContarStockProductoPorProducto(int idprod)
        {
            this.Inicializar($"contar los productos en bodega asociados al producto con el ID '{idprod}'");
            try
            {
                var bd = new base_datosEntities();
                int cantidad = bd.StockProducto.Count(s => s.idprod == idprod);
                bd.Dispose();
                return cantidad;
            }
            catch (Exception ex)
            {
                this.HayErrores = true;
                this.Mensaje = Util.MensajeError($"No fue posible {this.Accion}", ex);
                return -1;
            }
        }
    }
}
