using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Cliente
    {
        private String id;
        private String nombre;
        private String primerApellido;
        private String segundoApellido;
        private String direccion;
        private int telefono;
        private String estado;

        public DO_Cliente() {
        }

        public DO_Cliente(String _id, String _nombre, String _primerApellido, String _segundoApellido, String _direccion, int _telefono, String _estado) {
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
