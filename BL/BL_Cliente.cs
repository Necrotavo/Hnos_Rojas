using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DO_Credito ObtenerCredito() {
            if (cliente != null) {
                return cliente.credito;
            }
            return null;
        }

        public bool CrearCredito(int limiteCredito) {
            if (cliente.credito == null) {
                DO_Credito creditoNuevo = new DO_Credito(limiteCredito);
                //falta del Dao
                return true;
            }
            return false;
        }
    }
}
