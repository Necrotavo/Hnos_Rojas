using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DAO;

namespace BL
{
    public class BL_Pago
    {
        public int obtenerPagoProvDiaEspecifico(String diaInicio, String diaFinal)
        {
            try{
                DAO_Pago daoPago = new DAO_Pago();
                return daoPago.obtenerPagoProvDiaEspecifico(diaInicio, diaFinal);
            }
            catch {
                return 0;
            }
        }
    }
}
