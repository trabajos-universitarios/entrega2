using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenosAires.Model;
using BuenosAires.DataLayer;

namespace BuenosAires.BusinessLayer
{
    public class BcAnwoListaProducto
    {
        public string Accion = "";
        public string Mensaje = "";
        public bool HayErrores = false;
        public AnwoListaProducto AnwoListaProducto = null;
        public List<AnwoListaProducto> Lista = null;

        public BcAnwoListaProducto()
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
        public void CopiarPropiedades(DcAnwoListaProducto dc)
        {
            this.Accion = dc.Accion;
            this.Mensaje = dc.Mensaje;
            this.HayErrores = dc.HayErrores;
            this.AnwoListaProducto = dc.AnwoListaProducto;
            this.Lista = dc.Lista;
        }

        public void Reservar(string nroserieanwo)
        {
            var dc = new DcAnwoListaProducto();
            dc.Reservar(nroserieanwo);
            this.CopiarPropiedades(dc);
        }
        public void LeerTodos()
        {
            var dc = new DcAnwoListaProducto();
            dc.LeerTodos();
            this.CopiarPropiedades(dc);
        }


    }
}
