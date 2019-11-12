using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Proveedor
    {
        private DateTime fechaVisita;
        private List<DO_Asociado> listaAsociados;
        private String nombre;

        public DO_Proveedor() {
        }

        public DO_Proveedor(DateTime _fechaVisita, List<DO_Asociado> _listaAsociado, String _nombre) {
            this.fechaVisita = _fechaVisita;
            this.listaAsociados = _listaAsociado;
            this.nombre = _nombre;
        }
    }
}
