using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //cambio
    public class DO_Cliente : DO_Persona
    {   
        public String direccion { set; get; }
        public String estado { set; get; }
        public DO_Credito credito { set; get; }

        public DO_Cliente()  {
        }

        public DO_Cliente(int _id, String _nombre, String _primerApellido, String _segundoApellido, String _direccion, String _telefono, String _estado)
                    : base (_id,_telefono,_nombre,_primerApellido,_segundoApellido){
            
            this.direccion = _direccion;           
            this.estado = _estado;
        }
    }
}
