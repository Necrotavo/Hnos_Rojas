using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Sesion
    {
        private DO_Usuario usuario;
        private bool activo;

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
