using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenosAires.Model;

namespace BuenosAires.DataLayer
{
    public class DcAnwoListaProducto
    {
        public string Accion = "";
        public string Mensaje = "";
        public bool HayErrores = false;
        public AnwoListaProducto AnwoListaProducto = null;
        public List<AnwoListaProducto> Lista = null;

        public DcAnwoListaProducto()
        {
            Inicializar("");
        }

        private void Inicializar(string accion)
        {
            this.Accion = accion;
            this.Mensaje = "";
            this.HayErrores = false;
            this.AnwoListaProducto = null;
            this.Lista = null;
        }
        public void Reservar(string nroserieanwo)
        {
            this.Inicializar($"reservar el producto con el numero de serie '{nroserieanwo}'");
            try
            {
                var bd = new base_datosEntities();
                var encontrado = bd.AnwoListaProducto.FirstOrDefault(p => p.nroserieanwo == nroserieanwo);
                if (encontrado == null)
                {
                    this.Mensaje = $"No fue posible {this.Accion} pues no existe en la BD";
                }
                else
                {
                    encontrado.reservadoba = "S";
                    bd.SaveChanges();
                    this.AnwoListaProducto = new AnwoListaProducto();
                    Util.CopiarPropiedades(encontrado, this.AnwoListaProducto);
                    this.Mensaje = $"El producto '{AnwoListaProducto.nomprodanwo}' (Nro de Serie: {AnwoListaProducto.nroserieanwo}) fue reservado correctamente";
                }
                bd.Dispose();
            }
            catch (Exception ex)
            {
                this.HayErrores = true;
                this.Mensaje = Util.MensajeError($"No fue posible {this.Accion}", ex);
            }
        }

        public void LeerTodos()
        {
            this.Inicializar($"obtener la lista de productos");
            try
            {
                var bd = new base_datosEntities();
                this.Lista = bd.AnwoListaProducto.ToList();
                if (this.Lista.Count == 0) this.Mensaje = "La lista de productos se encuentra vacía";
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
