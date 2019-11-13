using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DO;

namespace BL
{
    public class BL_Credito
    {
        private DO_Credito credito;
        public BL_Credito() {
        }

        public bool agregarFactura(DO_Factura _factura) {
            
            return false;
        }

        public DO_Credito ObtenerCredito(int idCliente)
        {
            DAO_Credito daoCredito = new DAO_Credito();
            return daoCredito.ObtenerCredito(idCliente);
        }

        public bool CrearCredito(int idCliente, int limiteCredito)
        {
            DAO_Credito daoCredito = new DAO_Credito();
            return daoCredito.crearCredito(idCliente, limiteCredito);
        }
    }
}
