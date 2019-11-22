using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Asociado : DO_Persona
    {

        public String proveedor { set; get; }

        public DO_Asociado() {
        }

        public DO_Asociado(int _identificador, String _telefono, String _primerApellido, String _segundoApellido, String _nombre, String _nombreProveedor)
                : base(_identificador,_telefono,_primerApellido,_segundoApellido,_nombre){
           
            this.proveedor = _nombreProveedor;
        }
    }
}
