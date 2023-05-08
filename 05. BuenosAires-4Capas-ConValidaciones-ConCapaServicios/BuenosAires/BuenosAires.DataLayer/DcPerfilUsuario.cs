using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenosAires.Model;

namespace BuenosAires.DataLayer
{
    public class DcPerfilUsuario
    {
        public List<PerfilUsuario> ReadAll()
        {
            using (var bd = new base_datosEntities())
            {
                return bd.PerfilUsuario.ToList();
            }
        }
    }
}
