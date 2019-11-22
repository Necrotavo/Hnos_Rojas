using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Asociado : DO_Persona
    {
        //public String identificador { set; get;}
        //public String telefono { set; get; }
        //public String primerApellido { set; get; }
        //public String segundoApellido { set; get; }
        //public String nombre { set; get; }
        public String proveedor { set; get; }

        public DO_Asociado() {
        }

        public DO_Asociado(int _identificador, String _telefono, String _primerApellido, String _segundoApellido, String _nombre, String _nombreProveedor)
                : base(_identificador,_telefono,_primerApellido,_segundoApellido,_nombre){
            //this.identificador = _identificador;
            //this.telefono = _telefono;
            //this.primerApellido = _primerApellido;
            //this.segundoApellido = _segundoApellido;
            //this.nombre = _nombre;
            this.proveedor = _nombreProveedor;
        }
    }
}
