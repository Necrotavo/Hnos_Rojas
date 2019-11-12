using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_PlantillaFactura
    {
        private int numeroTelefono;
        private String nombreEmpresa;
        private String direccion;
        private String cedula;
        private int turno;
        private int folio;

        public DO_PlantillaFactura()
        {
        }

        public DO_PlantillaFactura(int _numeroTelefono, String _nombreEmpresa, String _direccion, 
            String _cedula, int _turno, int _folio)
        {
            this.numeroTelefono = _numeroTelefono;
            this.nombreEmpresa = _nombreEmpresa;
            this.direccion = _direccion;
            this.cedula = _cedula;
            this.turno = _turno;
            this.folio = _folio;
        }
    }
}
