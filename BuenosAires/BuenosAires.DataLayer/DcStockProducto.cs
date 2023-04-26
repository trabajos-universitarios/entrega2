using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenosAires.Model;

namespace BuenosAires.DataLayer
{
    public class DcStockProducto
    {
        public string Accion = "";
        public string Mensaje = "";
        public bool HayErrores = false;
        public StockProducto StockProducto = null;
        public List<StockProducto> Lista = null;

        public DcStockProducto()
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
        public int ObtenerSiguienteId()
        {
            this.Inicializar("obtener un nuevo ID");
            int siguienteId = -1;
            try
            {
                var bd = new base_datosEntities();
                siguienteId = 1;
                if (bd.Producto.Count() > 0) siguienteId = bd.Producto.Max(p => p.idprod) + 1;
                bd.Dispose();
                return siguienteId;
            }
            catch (Exception ex)
            {
                this.HayErrores = true;
                this.Mensaje = Util.MensajeError($"No fue posible {this.Accion}", ex);
                return -1;
            }
        }

        public void Crear(StockProducto stock)
        {
            this.Inicializar($"agregar el producto '{stock.idprod}' en la bodega");
            try
            {
                var bd = new base_datosEntities();
                int siguienteId = this.ObtenerSiguienteId();
                if (this.HayErrores) return;
                stock.idstock = siguienteId;
                bd.StockProducto.Add(stock);
                bd.SaveChanges();
                this.StockProducto = stock;
                bd.Dispose();
                this.Mensaje = $"El producto con el id '{stock.idprod}' fue creado correctamente";
            }
            catch (Exception ex)
            {
                this.HayErrores = true;
                this.Mensaje = Util.MensajeError($"No fue posible {this.Accion}", ex);
            }
        }

        public void LeerTodos()
        {
            this.Inicializar($"obtener la lista de productos en bodega");
            try
            {
                var bd = new base_datosEntities();
                this.Lista = bd.StockProducto.ToList();
                if (this.Lista.Count == 0) this.Mensaje = "La lista de productos en bodega se encuentra vacía";
                bd.Dispose();
            }
            catch (Exception ex)
            {
                this.HayErrores = true;
                this.Mensaje = Util.MensajeError($"No fue posible {this.Accion}", ex);
            }
        }

        public void Leer(int id)
        {
            this.Inicializar($"obtener el producto con el ID '{id}' desde la bodega");
            try
            {
                var bd = new base_datosEntities();
                this.StockProducto = bd.Producto.FirstOrDefault(p => p.idprod == id);
                bd.Dispose();
                if (this.Producto == null) Mensaje = $"No fue posible {this.Accion} pues no existe en la BD";
            }
            catch (Exception ex)
            {
                this.HayErrores = true;
                this.Mensaje = Util.MensajeError($"No fue posible {this.Accion}", ex);
            }
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
