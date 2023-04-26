using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenosAires.DataLayer;
using BuenosAires.Model;

namespace BuenosAires.BusinessLayer
{
    public class BcPerfilUsuario
    {
        public List<PerfilUsuario> ReadAll()
        {
            return new DcPerfilUsuario().ReadAll();
        }
    }
}
