using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //cambio
    public class DO_Persona
    {
        public int perIdentificador { set; get; }
        public String perTelefono { set; get; }
        public String perNombre { set; get; }
        public String perPrimerApellido { set; get; }
        public String perSegundoApellido { set; get; }

        public DO_Persona() {
        }

        public DO_Persona(int _perIdentificador, String _perTelefono, String _perNombre, String _perPrimerApellido, String _perSegundoApellido) {
            this.perIdentificador = _perIdentificador;
            this.perTelefono = _perTelefono;
            this.perNombre = _perNombre;
            this.perPrimerApellido = _perPrimerApellido;
            this.perSegundoApellido = _perSegundoApellido;
        }
    }
}
