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

        public DO_Credito ObtenerCredito(int idCliente, DateTime desde, DateTime hasta)
        {
            DAO_Credito daoCredito = new DAO_Credito();
            return daoCredito.ObtenerCredito(idCliente, desde, hasta);
        }

        public bool CrearCredito(int idCliente, int limiteCredito)
        {
            DAO_Credito daoCredito = new DAO_Credito();
            return daoCredito.crearCredito(idCliente, limiteCredito);
        }

        public double abonar(int abono, int idCredito)
        {
            DAO_Credito daoCredito = new DAO_Credito();
            return daoCredito.abonar(abono, idCredito);
        }

        public double obtenerMonto(int idCredito) {
            DAO_Credito daoFactura = new DAO_Credito();
            return daoFactura.obtenerMonto(idCredito);
        }

        public double calcularMonto(int idCredito)
        {
            List<DO_Factura> listaFacturas = new List<DO_Factura>();
            DAO_Factura daoFactura = new DAO_Factura();
            listaFacturas = daoFactura.obtenerFacturasCredito(idCredito);

            double monto = 0;

            foreach (DO_Factura factura in listaFacturas)
            {
                monto += factura.saldo;
            }

            return monto;
        }
    }
}
