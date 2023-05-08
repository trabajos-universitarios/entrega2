using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenosAires.Model;

namespace BuenosAires.DataLayer
{
    public class DcFactura
    {
        public string Accion = "";
        public string Mensaje = "";
        public bool HayErrores = false;
        public Factura Factura = null;
        public List<Factura> Lista = null;

        public DcFactura()
        {
            Inicializar("");
        }

        private void Inicializar(string accion)
        {
            this.Accion = accion;
            this.Mensaje = "";
            this.HayErrores = false;
            this.Factura = null;
            this.Lista = null;
        }
        public int ContarFacturasPorProducto(int idprod)
        {
            this.Inicializar($"contar las facturas asociadas al producto con el ID '{idprod}'");
            try
            {
                var bd = new base_datosEntities();
                int cantidad = bd.Factura.Count(f => f.idprod == idprod);
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

        public void LeerFacturasPorProductoId(int idprod)
        {
            this.Inicializar($"obtener la lista de facturas del producto con el ID '{idprod}'");
            try
            {
                var bd = new base_datosEntities();
                this.Lista = bd.Factura.Where(f => f.idprod == idprod).ToList();
                bd.Dispose();
            }
            catch (Exception ex)
            {
                this.HayErrores = true;
                this.Mensaje = Util.MensajeError($"No fue posible {this.Accion}", ex);
            }
        }
    }
}
