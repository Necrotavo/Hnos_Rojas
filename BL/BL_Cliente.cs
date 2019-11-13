using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DO;

namespace BL
{
    public class BL_Cliente
    {
        private DO_Cliente cliente;

        public BL_Cliente(DO_Cliente _cliente)
        {
            this.cliente = _cliente;
        }

        public BL_Cliente()
        {
            cliente = new DO_Cliente();
        }


    }
}
