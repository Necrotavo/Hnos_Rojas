﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //cambio
    public class DO_Usuario
    {
        public String nombreUsuario { set; get; }
        public String contrasena { set; get; }

        public DO_Usuario()
        {
        }

        public DO_Usuario(String _nombreUsuario, String _contrasena)
        {
            this.nombreUsuario = _nombreUsuario;
            this.contrasena = _contrasena;
        }
    }
}
