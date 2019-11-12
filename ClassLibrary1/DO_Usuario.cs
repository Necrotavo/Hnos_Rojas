using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Usuario
    {
        private String nombreUsuario;
        private String tipo;
        private String contrasena;

        public DO_Usuario(String _nombreUsuario, String _tipo, String _contrasena)
        {
            this.nombreUsuario = _nombreUsuario;
            this.tipo = _tipo;
            this.contrasena = _contrasena;
        }
    }
}
