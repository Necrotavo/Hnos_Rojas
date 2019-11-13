using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DAO;

namespace BL
{
   public class BL_Factura
    {
        public bool guardarFactura(DO_Factura factura) {
            DAO_Factura dao = new DAO_Factura();
            return dao.guardarFactura(factura);
        }
    }
}
