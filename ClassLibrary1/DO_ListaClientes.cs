﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_ListaClientes
    {
        private List<DO_Cliente> listaClientes { set; get; }

        public DO_ListaClientes()
        {
        }

        public DO_ListaClientes(List<DO_Cliente> _listaClientes)
        {
            this.listaClientes = _listaClientes;
        }
    }
}
