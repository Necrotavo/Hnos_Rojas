using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Cliente
    {
        public int id { set; get; }
        public String nombre { set; get; }
        public String primerApellido { set; get; }
        public String segundoApellido { set; get; }
        public String direccion { set; get; }
        public int telefono { set; get; }
        public String estado { set; get; }
        public DO_Credito credito { set; get; }

        public DO_Cliente() {
        }

        public DO_Cliente(int _id, String _nombre, String _primerApellido, String _segundoApellido, String _direccion, int _telefono, String _estado) {
            this.id = _id;
            this.nombre = _nombre;
            this.primerApellido = _primerApellido;
            this.segundoApellido = _segundoApellido;
            this.direccion = _direccion;
            this.telefono = _telefono;
            this.estado = _estado;
        }
    }
}
