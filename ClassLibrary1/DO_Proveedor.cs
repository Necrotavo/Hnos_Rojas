using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Proveedor
    {
        public String fechaVisita { set; get; }
        public List<DO_Asociado> listaAsociados { set; get; }
        public String nombre { set; get; }

        public DO_Proveedor() {
        }

        public DO_Proveedor(String _fechaVisita, List<DO_Asociado> _listaAsociado, String _nombre) {
            this.fechaVisita = _fechaVisita;
            this.listaAsociados = _listaAsociado;
            this.nombre = _nombre;
        }
    }
}
