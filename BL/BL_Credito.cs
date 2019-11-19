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
        public BL_Credito() {
        }

        public double CalcularSaldo(double limite, double monto)
        {
            return limite - monto;
        }
        public DO_Credito ObtenerDatosCredito(int idCliente)
        {
            DAO_Credito daoCredito = new DAO_Credito();
            return daoCredito.ObtenerDatosCredito(idCliente);
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

        public int abonar(int abono, int idCredito)
        {
            DAO_Credito daoCredito = new DAO_Credito();
            return daoCredito.abonar(abono, idCredito);
        }

        public int obtenerMonto(int idCredito) {
            DAO_Factura daoFactura = new DAO_Factura();
            return daoFactura.obtenerMonto(idCredito);
        }
    }
}
