﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Pago
    {
        public String id { set; get; }
        public DO_Proveedor proveedor { set; get; }
        public DO_Usuario usuario { set; get; }
        public DateTime fecha { set; get; }
        public int monto { set; get; }

        public DO_Pago()
        {
        }

        public DO_Pago(String _id, DO_Proveedor _proveedor, DO_Usuario _usuario, DateTime _fecha, int _monto)
        {
            this.id = _id;
            this.proveedor = _proveedor;
            this.usuario = _usuario;
            this.fecha = _fecha;
            this.monto = _monto;
        }
    }
}