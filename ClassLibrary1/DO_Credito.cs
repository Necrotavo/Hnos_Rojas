using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Credito
    {
        private int monto { set; get; }
        private int limiteCredito { set; get; }
        private List<DO_Factura> listaFactura { set; get; }

        public DO_Credito()
        {
        }

        public DO_Credito(int _monto, int _limiteCredito, List<DO_Factura> _listaFactura)
        {
            this.monto = _monto;
            this.limiteCredito = _limiteCredito;
            this.listaFactura = _listaFactura;
        }

        public List<DO_Factura> getListaFactura() {
            return listaFactura;
        }

        public DO_Credito(int _limiteCredito)
        {
            this.limiteCredito = _limiteCredito;
        }
    }
}
