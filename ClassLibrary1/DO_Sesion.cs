using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Sesion
    {
        public DO_Usuario usuario { set; get; }
        public bool activo { set; get; }

        public DO_Sesion()
        {
        }

        public DO_Sesion(DO_Usuario _usuario, bool _activo)
        {
            this.usuario = _usuario;
            this.activo = _activo;
        }
    }
}
