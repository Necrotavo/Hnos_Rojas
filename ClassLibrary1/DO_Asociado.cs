﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Asociado
    {
        private int telefono;
        private String primerApellido;
        private String segundoApellido;
        private String nombre;

        public DO_Asociado() {
        }

        public DO_Asociado(int _telefono, String _primerApellido, String _segundoApellido, String _nombre) {
            this.telefono = _telefono;
            this.primerApellido = _primerApellido;
            this.segundoApellido = _segundoApellido;
            this.nombre = _nombre;
        }
    }
}
