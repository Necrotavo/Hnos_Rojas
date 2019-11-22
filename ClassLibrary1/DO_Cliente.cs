using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Cliente : DO_Persona
    {

        public String direccion { set; get; }
        
        public String estado { set; get; }
        public DO_Credito credito { set; get; }

        public DO_Cliente() {
        }

        public DO_Cliente(int _id, String _nombre, String _primerApellido, String _segundoApellido, String _direccion, String _telefono, String _estado)
                    : base(_id,_nombre,_primerApellido,_segundoApellido,_telefono){
            
            this.direccion = _direccion;
            this.estado = _estado;
        }
    }
}
